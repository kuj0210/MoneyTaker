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
            self.initDB()

    # TODO : 해당 테이블 만드는 부분을 따로 분리할 필요가 있음. mariaDB로 옮긴 후에는 해당 initDB에 pass 로 치환할 것.
    def initDB(self):
        querys = [
            """CREATE TABLE mt_user
            (
                `index`  INT            NOT NULL    AUTO_INCREMENT, 
                `id`     VARCHAR(45)    NOT NULL, 
                `pw`     VARCHAR(45)    NOT NULL, 
                `token`  CHAR(256)      NOT NULL, 
                `class`  CHAR(45)       NULL, 
                PRIMARY KEY (index)
            );""",
            """CREATE TABLE mt_group
            (
                `gindex`  INT            NOT NULL    AUTO_INCREMENT, 
                `name`    VARCHAR(45)    NOT NULL, 
                `state`   VARCHAR(45)    NULL, 
                PRIMARY KEY (gindex)
            );""",
            """CREATE TABLE mt_iou
            (
                `rindex`          INT               NOT NULL    AUTO_INCREMENT, 
                `date`            TIMESTAMP         NOT NULL, 
                `borrower_index`  INT               NOT NULL, 
                `lender_index`    INT               NOT NULL, 
                `start_date`      DATETIME          NULL, 
                `end_date`        DATETIME          NULL, 
                `cost`            DECIMAL(18, 0)    NOT NULL, 
                `state`           INT               NULL, 
                PRIMARY KEY (rindex)
            );""",
            """CREATE TABLE mt_friendlist
            (
                `gindex`        INT    NOT NULL, 
                `index`         INT    NOT NULL, 
                `friend_index`  INT    NOT NULL, 
                `credit`        INT    NULL, 
                PRIMARY KEY (index, friend_index)
            );""",
            """CREATE TABLE mt_grouplist
            (
                `index`       INT    NOT NULL, 
                `gindex`      INT    NOT NULL, 
                `permission`  INT    NULL, 
                PRIMARY KEY (index, gindex)
            );"""
        ]
        for query in querys:
            self.query(query);

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