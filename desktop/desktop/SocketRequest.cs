using WebSocketSharp;
using Newtonsoft.Json.Linq;

namespace desktop
{
    public class SocketAPI
    {
        private string request_method;
        private string request_route = "";
        private JObject request_body;
        private JObject response = new JObject();

        private UserControl CurrentScreen;

        public SocketAPI()
        {
            request_method = "undefined";
        }
        private JObject buildRequest()
        {
            return new JObject(
                new JProperty("method", request_method),
                new JProperty("body", request_body),
                new JProperty("route", request_route));
        }


        public SocketAPI get()
        {
            request_method = "GET";
            return this;
        }
        public SocketAPI post()
        {
            request_method = "POST";
            return this;
        }
        public SocketAPI put()
        {
            request_method = "PUT";
            return this;
        }
        public SocketAPI delete()
        {
            request_method = "DELETE";
            return this;
        }

        public JObject Listas(string titulo)
        {
            request_route = "listas";
            request_body = new JObject(
                        new JProperty("filtro", titulo)
                    );

            switch (request_method)
            {
                case "GET":
                    return buildRequest();
                default:
                    MessageBox.Show("Esta requisição não existe!");
                    return new JObject(new JProperty("status", 400));

            }
        }
        public JObject Listas(int ID_lista)
        {
            request_route = "listas";
            switch (request_method)
            {
                case "GET":
                    request_body = new JObject(
                        new JProperty("id", ID_lista));
                    return buildRequest();
                case "DELETE":
                    request_body = new JObject(
                        new JProperty("id", ID_lista));
                    return buildRequest();
                default:
                    MessageBox.Show("Esta requisição não existe!");
                    return new JObject(new JProperty("status", 400));
            }
        }
        public JObject Listas(int[] matriculas, string titulo)
        {
            request_route = "listas";
            switch (request_method)
            {
                case "POST":
                    request_body = new JObject(
                        new JProperty("matriculas", matriculas),
                        new JProperty("titulo", titulo));
                    return buildRequest();
                default:
                    MessageBox.Show("Esta requisição não existe!");
                    return new JObject(new JProperty("status", 400));
            }
        }

        public JObject Alunos(string matricula)
        {
            request_route = "alunos";
            MessageBox.Show(matricula);
            int id;
            try
            {
                id = int.Parse(matricula);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return new JObject(new JProperty("status", 400));
            }


            switch (request_method)
            {
                case "GET":
                    request_body = new JObject(
                        new JProperty("matricula", id),
                        new JProperty("filtro", "matricula"));
                    return buildRequest();
                default:
                    MessageBox.Show("Esta requisição não existe!");
                    return new JObject(new JProperty("status", 400));
            }
        }
    }
}
