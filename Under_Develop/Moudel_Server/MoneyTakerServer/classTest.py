import json

class StrLetter:
    def __init__(self, other):
        self._keys = self.PasingKey(other)

    def SuchKey(self, other):
        if "List" in other:
            return "List"
        if "data" in other:
            return "data"

    def PasingKey(self, other):
        keylist = list(other)
        if ("List"in keylist) or ("data" in keylist):
            self.PasingData(self.SuchKey(keylist), other)
        return keylist

    def PasingData(self, keyvalue, other):
        datastring = other[keyvalue].split('\n')
        datalist = []
        for num in range(len(datastring)):
            datalist.append(datastring[num].split('\t'))
        other[keyvalue] = datalist

    def MakeCommad(self, other):
        totalstr = ''
        for dickey in self._keys:
            totalstr += str(dickey) + ':' + str(other[dickey]) + '\\n'
        return totalstr

class JsonController:
    def __init__(self, other):
        self.ary = other
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
    json1 = json.loads(array)
    example1 = JsonController(json1)
    print(example1)

    array = '{ "type": "login", ' \
            '"id": "user1", ' \
            '"pw": "UBNRE1YDUxo="}'
    json2 = json.loads(array)
    example2 = JsonController(json2)
    print(example2)

    array = '{ "type" : "logout", ' \
            '"token" : "HASH"}'
    json3 = json.loads(array)
    example3 = JsonController(json3)
    print(example3)

    array = '{ "type": "update-friend", ' \
            '"token": "HASH", ' \
            '"id": "hoho0220", ' \
            '"data-count": "3", ' \
            '"data": "1_on\\t연구실\\t1_on@naver.com\\n*123jejuS2\\t후배\\tjeju@kumoh.com\\nhoho0220@hanmail.net\\t후배\\thoho0220@hanmail.net"' \
            '}'
    json4 = json.loads(array)
    example4 = JsonController(json4)
    print(example4)

    array = '{ "type": "delete-friend", ' \
            '"token": "HASH", ' \
            '"Tuple-count": "1", ' \
            '"data-count": "1", ' \
            '"List": "hoho0220\\t연구실\\thoho0220@hanmail.net"' \
            '}'
    json5 = json.loads(array)
    example5 = JsonController(json5)
    print(example5)