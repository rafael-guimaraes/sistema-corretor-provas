from setup.env import env
env = env()
class ImportCSV():

    def __init__(self,p:str = "",translator:dict = dict()) -> None:
        self._path = p
        self._fields = translator # CSV : MongoDB
        self._csv_indexes = {}

    def setPath(self,p:str):
        self._path = p
    def setFields(self,translator:dict):
        self._fields = translator

    
    def _buildJSON(self,fields:list):
        json = {}
        for i,v in self._csv_indexes.items():
            json[self._fields[v]] = fields[i]
        return json

    def _issues(self):

        # Counts each occurrence of needed fields (n != 1 -> issue)

        csv_requirements = tuple(self._fields.keys())
        found_issues = tuple(map(lambda item: tuple(self._csv_indexes.values()).count(item),csv_requirements))
        num_issues = len(found_issues) - found_issues.count(1)

        if num_issues == 0: return None,None

        text_issues = f"\n{num_issues} issues were found in {self._path}\n"
        fields = []
        for i,value in enumerate(found_issues):
            if (value != 1):
                text_issues += f" - {csv_requirements[i]} has {value} occurrences (1 expected).\n"
                fields.append(csv_requirements[i])
        return text_issues, fields


    def read(self):

        # Reads the file
        File = open(self._path,encoding="utf-8-sig")
        lines = File.readlines()
        File.close()

        # Breaks lines, then its fields ((),())
        lines_fields = tuple(map(lambda i: tuple(i[:-1].split(env.CSV_NOTATION(self._path))),lines))

        # Gets the needed fields and its index according to the header
        self._csv_indexes = dict(filter(lambda key:key[1] in self._fields.keys(),tuple(enumerate(lines_fields[0]))))

        # Check duplicates or missing
        issues,fields = self._issues()        
        if issues:
            return {
                "status":"erro",
                "content":issues,
                "data":fields
            }
        
        # Builds JSON to each Line
        jsons = tuple(map(self._buildJSON,lines_fields[1:]))
        return {
            "status":"success",
            "content":f"CSV was successfully read! ({len(jsons)} lines)",
            "data":jsons
        }