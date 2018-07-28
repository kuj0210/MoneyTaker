import unittest
import json
from flask import Flask
from MoneyTakerServer import *

ENCRYPT_KEY = 'abcdefghijklmnopqrstuvwxyz123456'

class MoneyTakerServerTest(unittest.TestCase):

    # before
    def setUp(self):  # 새로운 테스트 클라이언트를 생성
        self.app = app.test_client()

    # after
    def tearDown(self):
        try:
            dbc.delete(DB_TABLE_USER, "id='user2'")
        except:
            pass

    def test_database_query(self):  # 데이터베이스 쿼리문에 대한 정상 동작 확인
        result = dbc.query("SELECT Char(97)")
        self.assertEqual(result[0][0], 'a')

    def test_database_select(self):  # 데이터베이스 유저 아이디에 대한 비밀번호 확인
        result = dbc.select(DB_TABLE_USER, "id='user1'")
        self.assertEqual(result[0][1], xor_encrypt('1q2w3e4r', ENCRYPT_KEY))

    def test_database_insert(self):
        result = dbc.insert(DB_TABLE_USER, "'user3', 'password1234', 'TEMP_TOKEN', 'user'")
        self.assertEqual(result, [])

    def test_database_delete(self):
        result = dbc.delete(DB_TABLE_USER, "id='user3'")
        self.assertEqual(result, [])

    def test_register_new_user(self):  # 존재하지 않는 아이디를 가입.
        p = self.app.post('/',
                          json={'type':'register','id': 'user2', 'pw': xor_encrypt('1q2w3e4r', ENCRYPT_KEY), 'class': 'user'})
        result = json.loads(p.data)
        self.assertEqual(result["result"], "failed")

    def test_register_exist_user(self):  # 이미 가입되어 있는 아이디를 가입.
        p = self.app.post('/',
                          json={'type': 'register', 'id': 'user1', 'pw': xor_encrypt('1q2w3e4r', ENCRYPT_KEY), 'class': 'user'})
        result = json.loads(p.data)
        self.assertEqual(result["result"], "failed")

    def test_login_normal(self):  # 정상 로그인
        p = self.app.post('/', json={'type': 'login', 'id': 'user1', 'pw': xor_encrypt('1q2w3e4r', ENCRYPT_KEY)})
        result = json.loads(p.data)
        self.assertEqual(result["result"], "success")

    def test_login_abnormal(self):  # 잘못된 비밀번호로 로그인
        p = self.app.post('/', json={'type':'login','id': 'user1', 'pw': xor_encrypt('1q2w3e4r5t', ENCRYPT_KEY)})
        result = json.loads(p.data)
        self.assertEqual(result["result"], "failed")

if __name__ == "__main__":
    unittest.main()
