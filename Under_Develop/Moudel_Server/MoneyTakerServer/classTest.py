import json

class StrLetter:
    def __init__(self, other):
        self.keys = self.Pasing(other)

    def Pasing(self, other):
        return list(other)

    def MakeCommad(self, other):
        totalstr = ''
        for dickey in self.keys:
            totalstr += str(dickey) + ':' + str(other[dickey]) + '\\n'
        return totalstr

class JsonStr:
    def __init__(self, other):
        self.ary = json.loads(other)
        self.letter = StrLetter(self.ary)

    def __str__(self):
        return "Key == " + self.letter.MakeCommad(self.ary)

    def SendMsg(self):
        # If you want to use a json string of this class,
        # you should be used next code.
        # self.letter.MakeCommand(self.ary)
        pass

if __name__ == "__main__":
    array = '{' \
            '"type": "register", ' \
            '"id": "user1",' \
            '"pw": "UBNRE1YDUxo="}'
    strjson = JsonStr(array)
    print(strjson)