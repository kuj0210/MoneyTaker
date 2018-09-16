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

##
## json URL examples for test
##

# login example 1-1-1 Riny's id
#usually id and pw form

json = {
    'type': 'login',
    'id': 'hoho0220',
    'pw': 'skaeo159357' }
sendJSON(URL, json)

# login example 1-1-2 ujin's id
# # include special character in pw
# # The first letter of id is a number
json = {
    'type': 'login',
    'id': '1_on',
    'pw': '1q2w3e4r!@'}
sendJSON(URL, json)

# login example 1-1-3 jinhuk's id
# include special character in pw
# The first letter of id is special character
# The first and last letter of pw is special charater
json = {
    'type': 'login',
    'id': '*123jejuS2',
    'pw': '!12345678*'}
sendJSON(URL, json)

# login example 1-1-4 deasunk's id
# The first letter of id is special character '_'
# The first letter of pw is special character '/'
json = {
    'type': 'login',
    'id': '_DeaGu__',
    'pw': '/123*sukS2'}
sendJSON(URL, json)

# login example 1-1-5 wonlyang's id
# id is email address
# pw is charter + special charter
json = {
    'type': 'login',
    'id': 'hoho0220@hanmail.net',
    'pw': 'skaeo!@#$%'}
sendJSON(URL, json)


####### example 1-2 start ###########


# login example 1-2-1 Riny's response 10 minute
json = {
    'type': 'login-response',
    'id': 'HASH(hoho0220 + 10)',
    'pw': 'HASH(hoho0220 + 10)'}
sendJSON(URL, json)

# login example 1-2-2 ujin's response 10 minute
# Situation of the same time with Riny
json = {
    'type': 'login-response',
    'id': 'HASH(1_on + 10)',
    'pw': 'HASH(1_on + 10)'}
sendJSON(URL, json)

# login example 1-2-3 jinhuk's response 35 minute
json = {
    'type': 'login-response',
    'id': 'HASH(*123jejuS2 + 35)',
    'pw': 'HASH(*123jejuS2 + 35)'}
sendJSON(URL, json)

# login example 1-2-4 deasunk's response 47 minute
json = {
    'type': 'login-response',
    'id': 'HASH(_DeaGu__ + 47)',
    'pw': 'HASH(_DeaGu__ + 47)'}
sendJSON(URL, json)

# login example 1-1-5 wonlyang's response 53 minute
json = {
    'type': 'login-response',
    'id': 'HASH(hoho0220@hanmail.net + 53)',
    'pw': 'HASH(hoho0220@hanmail.net + 53)'}
sendJSON(URL, json)


#########3 start ###############
######### i think, this command need id in json code ####

## load of dealing data from Riny

json = {
    'type': 'load-friend/deal',
    'token': 'HASH',
    'Tuple-count': '3',
    'data-count': '3',
    'List': '1_on/채무자/10000/1_on@naver.com\n'+
              '*123jejuS2/채권자/10000/jeju@kumoh.com\n'+
              '_DeaGu__/채권자/20000/_DeaGu__@gmail.com'
}
sendJSON(URL, json)

### load of dealing data from ujin

json = {
    'type': 'load-deal',
    'token': 'HASH',
    'Tuple-count': '3',
    'data-count': '3',
    'List': 'hoho0220/채권자/10000/hoho0220@hanmail.net\n'+
              '*123jejuS2/채무자/10000/jeju@kumoh.com\n'+
              'hoho0220@hanmail.net/채권자/20000/hoho0220@hanmail.net'
}
sendJSON(URL, json)

### delete dealing data of ujin and RIny

json = {
    'type': 'delete-deal',
    'token': 'HASH',
    'Tuple-count': '1',
    'data-count': '1',
    'List': 'hoho0220/채권자/10000/hoho0220@hanmail.net'
}
sendJSON(URL, json)

# ujin's add friend
# check for cyntax
# Is correct commander Add friend??

json = {
    'type': 'Add-friend',
    'token': 'HASH',
    'Tuple-count': '1',
    'data-count': '1',
    'List': 'hoho0220/연구실/hoho0220@hanmail.net'
}
sendJSON(URL, json)

### ujin's delete friend

json = {
    'type': 'delete-friend',
    'token': 'HASH',
    'Tuple-count': '1',
    'data-count': '1',
    'List': 'hoho0220/연구실/hoho0220@hanmail.net'
}
sendJSON(URL, json)

###### 4 example

json = {
    'type': 'update-friend',
    'token': 'HASH',
    'id': 'hoho0220',
    'data-count': '3',
    'data': '1_on\t연구실\t1_on@naver.com\n'+
             '*123jejuS2\t후배\tjeju@kumoh.com\n'+
             'hoho0220@hanmail.net\t후배\thoho0220@hanmail.net'
}
sendJSON(URL, json)


### send logout command Riny

json = {
    'type': 'logout',
    'id': 'hoho0220',
    'token': 'HASH'
}
sendJSON(URL, json)

json = {
    'type': 'update',
    'id': '1_on',
    'token': 'HASH'
}
sendJSON(URL, json)