import requests

URL = 'http://localhost:8888'
headers = {'Content-Type': 'application/json; charset=utf-8'}

def sendJSON(URL, json):
    res = requests.post(URL, json=json,headers=headers	)
    print(res.status_code)
    print(res.text)

# 1. 회원가입 테스트 (이미 있는 유저인 경우 result가 failed로 나옴.
json = {
    'type': 'register',
    'id': 'user1',
    'pw': 'UBNRE1YDUxo='}
sendJSON(URL, json)

# 2. 로그인 테스트
json = {
    'type': 'login',
    'id': 'user1',
    'pw': 'UBNRE1YDUxo='}
sendJSON(URL, json)

