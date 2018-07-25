# -*- coding: utf-8 -*-
# this is not moneyTaker source. :(. just dummy. sorry.

from flask import Flask, request, jsonify

from DB.DBManager import DBManager
# from Util import AESCipher
import base64

# DB_HOST = "localhost"
# DB_USER = "root"
# DB_PW = "root_pw"
DB_DATABASE = "moneytaker"

DB_TABLE_USER = "mt_user"

# 암호화 키
ENCRYPT_KEY = 'abcdefghijklmnopqrstuvwxyz123456'


#
# NB : this is not secure
# from http://code.activestate.com/recipes/266586-simple-xor-keyword-encryption/
# added base64 encoding for simple querystring :)
#

def xor_encrypt(data, key):
    return base64.b64encode(bytearray(a ^ b for a, b in zip(*map(bytearray, [data.encode(), key.encode()])))).decode(
        'utf-8')


app = Flask(__name__)
dbc = DBManager(dbn=DB_DATABASE)


@app.route('/', methods=['POST'])
def main():
    try:
        dataReceive = request.get.json()
    except Exception as e:
        print(e)
    msgType = dataReceive['type']
    if msgType == 'register':
        return Register(dataReceive)
    elif msgType == 'login':
        return Login(dataReceive)
    elif msgType == 'IOU':
        pass
    elif msgType == 'friend':
        pass
    else:
        print(msgType, "is invaild message type.")

def Register(dataReceive):
    print("[REGISTER]", "REQUEST:", dataReceive)
    id = dataReceive['id']
    pw = dataReceive['pw']
    token = xor_encrypt(id + pw, ENCRYPT_KEY)
    permission = dataReceive['class']
    try:
        # dbc = DBManager(_host=DB_HOST, _db=DB_DATABASE, _user=DB_USER, _password=DB_PW)
        # dbc.connect()
        result = dbc.insert(DB_TABLE_USER,
                            args="\'{id}\',\'{pw}\',\'{token}\',\'{permission}\'".format(id=id, pw=pw, token=token,
                                                                                         permission=permission))
        # dbc.close()
    except Exception as e:
        print(e)
        print("[REGISTER]", "REQUEST:", "DB INSERT ERROR.")
        dataSend = {
            "type": "register"
            , "result": "failed"
            , "info": str(e)
        }
    else:
        if result == []:
            dataSend = {
                "type": "register"
                , "result": "failed"
                , "info": "not found"
            }
        else:
            dataSend = {
                "type": "register"
                , "result": "success"
                , "AuthToken": result[0][2]
            }
    print(dataSend)
    return jsonify(dataSend)


def Login(dataReceive):
    print("[LOGIN]", "REQUEST:", dataReceive)
    id = dataReceive['id']
    pw = dataReceive['pw']
    try:
        # dbc.connect()
        result = dbc.select(DB_TABLE_USER, "id=\'{id}\' and pw=\'{pw}\'".format(id=id, pw=pw))
        # dbc.close()
    except Exception as e:
        print(e)
        print("[LOGIN]", "REQUEST:", "DB SELECT ERROR.")
        dataSend = {
            "type": "login"
            , "result": "failed"
            , "info": str(e)
        }
    else:
        if result == []:
            dataSend = {
                "type": "login"
                , "result": "failed"
                , "info": "not found"
            }
        else:
            dataSend = {
                "type": "login"
                , "result": "success"
                , "AuthToken": result[0][2]
            }
    print(dataSend)
    return jsonify(dataSend)

if __name__ == "__main__":
    app.run(host='0.0.0.0', port=80, debug=True)
