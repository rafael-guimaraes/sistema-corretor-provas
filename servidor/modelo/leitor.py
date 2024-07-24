from cryptography.hazmat.primitives.ciphers import Cipher, algorithms, modes
from cryptography.hazmat.backends import default_backend
from pyzbar.pyzbar import decode
from base64 import b64decode
from uuid import uuid4
import numpy as np
import shutil
import cv2
import os


class Leitor:
    def ler_provas(self, pasta_provas):
        """
        Retorna uma lista de objetos Prova gerados a partir das imagens da pasta.

        Parâmetros:
        - pasta_provas (str): O caminho da pasta que contém as imagens da prova.
        """
        provas = []
        for root, _, files in os.walk(pasta_provas):
            for file in files:
                caminho_prova = os.path.join(root, file)
           
                provas.append(self.ler_prova(caminho_prova))
        return provas
    
    def ler_prova(self, rota_imagem):
        """
        Retorna um objeto Prova gerado a partir da imagem da rota.

        Parâmetros:
        - rota_imagem (str): O caminho da imagem da prova.
        """
        
        try:
            
            img = cv2.imread(rota_imagem)
            
            img_cinza = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
            _, img_binaria = cv2.threshold(img_cinza, 190, 255, cv2.THRESH_BINARY_INV)
            
            
            
            self.img_original = img
            # dados_prova = self.ler_qr(img, b'01234567890123456789012345678901')
            respostas = self.ler_respostas(img_binaria)

            return respostas

        except cv2.error as e:
            print(f"Erro ao processar imagem {rota_imagem}: {e}")
            return None
        except Exception as e:
            print(f"Erro inesperado ao ler prova {rota_imagem}: {e}")
            return None

    def ler_qr(self, img, chave):
        """
        Lê o QR code de uma imagem e retorna os dados descriptografados.

        Parâmetros:
        - img (numpy.ndarray): A imagem contendo o QR code.
        - chave (bytes): A chave para descriptografar os dados do QR code.
        """
        try:
            dados_qr = decode(img[100:600, 1700:])
            if dados_qr:
                dados_qr = dados_qr[0]
                cipher = Cipher(algorithms.AES(chave), modes.ECB(), backend=default_backend())
                decryptor = cipher.decryptor()
                texto_descriptografado = (decryptor.update(b64decode(dados_qr.data)) + decryptor.finalize()).decode('utf-8')
                return eval(texto_descriptografado)
            return {}
        except Exception as e:
            print(f"Erro inesperado ao ler QR code: {e}")
            return {}
    def rotacaoDireita(self, pontos):
    
        pontos = sorted(pontos.reshape(4, 2), key=lambda x: (x[0], x[1]))
        A, _, C, _ = sorted(pontos[:2], key=lambda x: x[1]) + sorted(pontos[2:], key=lambda x: x[1])
        
        return  A[1] < C[1]
    def ler_respostas(self, img):
        """
        Processa a imagem binária de respostas e retorna as respostas.

        Parâmetros:
        - img (numpy.ndarray): Imagem binária contendo as respostas.
        """
        try:
            hh, ww = img.shape[:2]

            pad = cv2.copyMakeBorder(img, 20, 20, 20, 20, borderType=cv2.BORDER_CONSTANT, value=0)

            kernel = cv2.getStructuringElement(cv2.MORPH_ELLIPSE, (15, 15))
            morph = cv2.morphologyEx(pad, cv2.MORPH_CLOSE, kernel)

            morph = morph[20:hh+20, 20:ww+20]

            contours, _ = cv2.findContours(morph, cv2.RETR_LIST, cv2.CHAIN_APPROX_SIMPLE)
            contours = sorted(contours, key=lambda x: cv2.contourArea(x), reverse=True)

            if len(contours) > 1:
                big_contour = contours[1]
            else:
                raise ValueError("Menos de dois contornos encontrados.")

            
            
            peri = cv2.arcLength(big_contour, True)
            corners = cv2.approxPolyDP(big_contour, 0.04 * peri, True)

            polygon = img.copy()
            cv2.polylines(polygon, [corners], True, (0, 255, 0), 2, cv2.LINE_AA)
            
            icorners = []
            for corner in corners:
                pt = [ corner[0][0],corner[0][1] ]
                icorners.append(pt)
            icorners = np.float32(icorners)
            
            if self.rotacaoDireita(corners):
                ocorners = np.float32([[0, 0], [612, 0], [612, 778], [0, 778]])
            else:
                ocorners = np.float32([[612, 0], [612, 778], [0, 778], [0, 0]])

            M = cv2.getPerspectiveTransform(icorners, ocorners)
            
            img = cv2.warpPerspective(img, M, (612, 778))
            
            cv2.imshow("a", img)
            
            cv2.waitKey(0)
   
             
            contornos, _ = cv2.findContours(img, cv2.RETR_LIST, cv2.CHAIN_APPROX_SIMPLE)
            contornos = [c for c in contornos]
            contornos.sort(key=lambda x: cv2.contourArea(x), reverse=True)
            print(cv2.contourArea(contornos[0]))
            contorno = contornos[0]
            x, y, w, h = cv2.boundingRect(contorno)

            imgPerguntas = img[y:y+h, x:x+w]
           
           
            horizontal_kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (100, 1))
            horizontal_lines = cv2.morphologyEx(imgPerguntas, cv2.MORPH_OPEN, horizontal_kernel)

            horizontal_lines_visual = cv2.normalize(horizontal_lines, None, 0, 255, cv2.NORM_MINMAX)

            _, horizontal_lines_visual = cv2.threshold(horizontal_lines_visual, 1, 255, cv2.THRESH_BINARY)

            
            alturas_unicas = np.unique(np.where(horizontal_lines > 0)[0])
            alturas_linhas = []
            if len(alturas_unicas) > 0:
                grupo_atual = [alturas_unicas[0]]
                for i in range(1, len(alturas_unicas)):
                    if alturas_unicas[i] - alturas_unicas[i - 1] > 1:
                        altura_media = int(np.mean(grupo_atual))
                        alturas_linhas.append(altura_media)
                        grupo_atual = [alturas_unicas[i]]
                    else:
                        grupo_atual.append(alturas_unicas[i])
                
                if len(grupo_atual) > 0:
                    altura_media = int(np.mean(grupo_atual))
                    alturas_linhas.append(altura_media)
            print(alturas_linhas)
            
            
            
            
            imgPerguntas = imgPerguntas[alturas_linhas[3]:alturas_linhas[7], :]    
            vertical_kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (1, 40))
            vertical_lines = cv2.morphologyEx(imgPerguntas, cv2.MORPH_OPEN, vertical_kernel)
            

            larguras_unicas = np.unique(np.where(vertical_lines > 0)[1])
            larguras_linhas = []

            if len(larguras_unicas) > 0:
                grupo_atual = [larguras_unicas[0]]
                for i in range(1, len(larguras_unicas)):
                    if larguras_unicas[i] - larguras_unicas[i - 1] > 1:
                        largura_media = int(np.mean(grupo_atual))
                        larguras_linhas.append(largura_media)
                        grupo_atual = [larguras_unicas[i]]
                    else:
                        grupo_atual.append(larguras_unicas[i])
                
                if len(grupo_atual) > 0:
                    largura_media = int(np.mean(grupo_atual))
                    larguras_linhas.append(largura_media)
            letras = "abcdex"
            res = []
            for i in range(10):
                pergunta = imgPerguntas[ : , larguras_linhas[i + 1]:larguras_linhas[i + 2]]     
                alternativas = np.array_split(pergunta, 5, axis=0)
    
                valores_alternativas = []
                for alternativa in alternativas:
                    ponto = [int(round(alternativa.shape[1] / 2)), int(round(alternativa.shape[0] / 2))]
                    mascara = np.zeros_like(alternativa, dtype=np.uint8)
                    cv2.circle(mascara, (ponto[0], ponto[1]), int(alternativa.shape[1] * 0.35), (255, 255, 255), -1)
                    
                    circulo = cv2.bitwise_and(alternativa, alternativa, mask=mascara)
                    valor_alternativa = cv2.mean(circulo, mask=mascara)[0]
                    
                    valores_alternativas.append(valor_alternativa)
                
                
                
                media = (sum(valores_alternativas) - min(valores_alternativas) - max(valores_alternativas)) / 3
                valores_alternativas = [a - media for a in valores_alternativas]
                alternativas_marcadas = [idx for idx, valor in enumerate(valores_alternativas) if valor > 70]
                
                resultado = alternativas_marcadas[0] if len(alternativas_marcadas) == 1 else 5
                res.append(letras[resultado])

                    
            """
            contornos, _ = cv2.findContours(linhas, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)
            cv2.drawContours(self.img_original, contornos, -1, (0, 255, 0), 2)  # -1 means draw all contours, thickness = 2

            cv2.imshow('Contours', linhas)
            cv2.waitKey(0)
            contornos = [c for c in contornos if 450 > cv2.contourArea(c) > 330]
            contornos.sort(reverse = True, key=lambda x: cv2.contourArea(x))
            
                
        
            x0, y0, xf, yf = cv2.boundingRect(np.concatenate(contornos))
            imgRespostas = imgPerguntas[y0: yf + y0, x0: xf + x0]
            
            resQuestoes_linhas = np.array_split(imgRespostas, 10, axis=1)
            resQuestoes = [np.array_split(part, 5, axis=0) for part in resQuestoes_linhas]

            
            for val, questao in enumerate(resQuestoes):
                
                alternativas = []
                for num_alternativa, alternativa in enumerate(questao):
                    ponto = [int(round(alternativa.shape[1] / 2)), int(round(alternativa.shape[0] / 2))]
                    mascara = np.zeros_like(alternativa, dtype=np.uint8)
                    cv2.circle(mascara, ponto, int(alternativa.shape[1] * 0.35), (255, 255, 255), -1)
                    circulo = cv2.bitwise_and(alternativa, mascara)
                    valor_alternativa = cv2.mean(circulo, mask=mascara)[0]
                    
                    alternativas.append(valor_alternativa)
                    
                media = (sum(alternativas) - min(alternativas) - max(alternativas)) / 3
                alternativas = [a - media for a in alternativas]
                alternativas_marcadas = [i for i, valor in enumerate(alternativas) if valor > 30]

                resultado = alternativas_marcadas[0] if len(alternativas_marcadas) == 1 else 5
                res.append(letras[resultado])
                
            """
           
            return res 
        except Exception as e:
            print(f"Erro ao ler respostas: {e}")
            return []
        
    def mover_prova(self, prova):
        """
        Move uma prova para uma pasta específica.

        Parâmetros:
        - prova (Prova): Objeto Prova a ser movido.
        """
        try:
            if prova.matricula != "" and prova.respostas != "":
                rota = f"C:\\provas\\{prova.disciplina}_{prova.bimestre}"
                os.makedirs(rota, exist_ok=True)
                shutil.move(prova.rota, os.path.join(rota, f"{prova.matricula}.png"))
                prova.rota = f"{rota}{prova.matricula}.png"
                return prova
            else:
                rota = f"C:\\provas\\provas_com_erro"
                os.makedirs(rota, exist_ok=True)
                shutil.move(prova.rota, os.path.join(rota, f"{uuid4()}.png"))
                prova.rota = f"{rota}{prova.matricula}.png"
                return prova
        except Exception as e:
            print(f"Erro ao mover prova para {rota}: {e}")
            return prova
    

provas = Leitor().ler_provas("C:\\Users\\rafae\\Desktop\\pasta_selecionada")
for prova in provas:
    print(prova)
