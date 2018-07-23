# -*- coding: utf-8 -*-
#this is not moneyTaker source. :(. just dummy. sorry.

from flask import Flask, request, jsonify

from DB.DBManager import DBManager
# from Util import AESCipher
import base64

# DB_HOST = "localhost"
# DB_USER = "root"
# DB_PW = "root_pw"
DB_DATABASE = "myshoppingmall"

DB_TABLE_USER = "ms_user"
DB_TABLE_LINEITEM = "ms_lineitem"
DB_TABLE_MYCART = "ms_shoppingcart"

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


@app.route('/register', methods=['POST'])
def Register():
    dataReceive = request.get_json()
    print("[REGISTER]", "REQUEST:", dataReceive)
    id = dataReceive['id']
    pw = dataReceive['pw']
    token = xor_encrypt(id + pw, ENCRYPT_KEY)
    permission = dataReceive['class']
    try:
        # dbc = DBManager(_host=DB_HOST, _db=DB_DATABASE, _user=DB_USER, _password=DB_PW)
        #dbc.connect()
        result = dbc.insert(DB_TABLE_USER,
                            args="\'{id}\',\'{pw}\',\'{token}\',\'{permission}\'".format(id=id, pw=pw, token=token,
                                                                                         permission=permission))
        #dbc.close()
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


@app.route('/login', methods=['POST'])
def Login():
    dataReceive = request.get_json()
    print("[LOGIN]", "REQUEST:", dataReceive)
    id = dataReceive['id']
    pw = dataReceive['pw']
    try:
        #dbc.connect()
        result = dbc.select(DB_TABLE_USER, "id=\'{id}\' and pw=\'{pw}\'".format(id=id, pw=pw))
        #dbc.close()
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


@app.route('/lineitem', methods=['POST'])
def sendItemList():
    dataReceive = request.get_json()
    print("[LINEITEM]", "REQUEST:", dataReceive)
    try:
        #dbc.connect()
        result = dbc.query("select * from {0}".format(DB_TABLE_LINEITEM))
        print(result)
        #dbc.close()
    except Exception as e:
        print(e)
        print("[LINEITEM]", "REQUEST:", "DB SELECT ERROR.")
        dataSend = {
            "type": "lineitem"
            , "result": "failed"
            , "info": str(e)
        }
    else:
        if result == []:
            dataSend = {
                "type": "lineitem"
                , "result": "failed"
                , "info": "not found"
            }
        else:
            dataSend = {
                "type": "lineitem"
                , "result": "success"
                , "itemlist": result
            }
    print(dataSend)
    return jsonify(dataSend)


@app.route('/shoppingcart', methods=['POST'])
def sendmyshoppingcart():
    dataReceive = request.get_json()
    print("[MYCART]", "REQUEST:", dataReceive)
    id = dataReceive['id']
    try:
        #dbc.connect();
        result = dbc.select(DB_TABLE_MYCART, "id=\'{id}\'".format(id=id))
        #dbc.close()
    except Exception as e:
        print(e)
        print("[MYCART]", "REQUEST:", "DB SELECT ERROR.")
        dataSend = {
            "type": "mycart"
            , "result": "failed"
            , "info": str(e)
        }
    else:
        dataSend = {
            "type": "mycart"
            , "result": "success"
            , "shoppingcart": result
        }
    print(dataSend)
    return jsonify(dataSend)


if __name__ == "__main__":
    app.run(host='0.0.0.0', port=8000, debug=True)
