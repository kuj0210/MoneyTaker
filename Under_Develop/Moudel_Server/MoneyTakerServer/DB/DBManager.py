"""
기본 샘플 코드 (예제로 배우는 Python 프로그래밍에서 발췌)
http://pythonstudy.xyz/python/article/202-MySQL-%EC%BF%BC%EB%A6%AC

#2차 수정 : hyeon jin-hyeok.
#변경 내용 : 클래스화.
"""
import sqlite3
import os

class DBManager:
    def __init__(self, dbn: str):
        self.db = dbn
        if not os.path.isfile("%s.db" %(dbn)):
            self.connect()
            self.query("""CREATE TABLE ms_user
                (
                    id     CHAR(45)     NOT NULL, 
                    pw     CHAR(45)     NOT NULL, 
                    token  CHAR(256)    NOT NULL, 
                    class  CHAR(45)     NULL,
                    PRIMARY KEY(id)
                );""")
            self.query("""CREATE TABLE ms_lineitem
                    (
                        iid       INTEGER PRIMARY KEY AUTOINCREMENT, 
                        name      CHAR(45)       NOT NULL, 
                        quantity  INT            NOT NULL, 
                        cost      INT            NOT NULL
                    );""")
            self.query("""CREATE TABLE ms_shoppingcart
                    (
                        id        CHAR(45)       NOT NULL, 
                        iid       INTEGER            NOT NULL, 
                        quantity  INT            NULL, 
                        PRIMARY KEY (id,iid)
                    );""")
            self.close()


    def connect(self):
        self.conn = sqlite3.connect("%s.db" % (self.db), isolation_level=None)

    def query(self, query):
        # Connection 으로부터 Cursor 생성
        self.connect()
        with self.conn:
            curs = self.conn.cursor()
            curs.execute(query)
            result = curs.fetchall()
        self.close()
        return result

    def select(self, table, args=""):
        iquery = "SELECT * FROM {0} WHERE {1};".format(table, args)
        return self.query(iquery)

    def insert(self, table, args=""):
        iquery = "INSERT INTO {0} VALUES({1});".format(table, args)
        return self.query(iquery)

    def delete(self, table, args=""):
        iquery = "DELETE FROM {0} WHERE {1};".format(table, args)
        return self.query(iquery)

    def close(self):
        self.conn.close()