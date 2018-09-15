"""
기본 샘플 코드 (예제로 배우는 Python 프로그래밍에서 발췌)
http://pythonstudy.xyz/python/article/202-MySQL-%EC%BF%BC%EB%A6%AC

#2차 수정 : hyeon jin-hyeok.
#변경 내용 : 클래스화.
"""
import pymysql
import os

class DBManager:
    def __init__(self, dbn: str):
        self.db = dbn
        if not os.path.isfile("%s.db" %(dbn)):
            self.initDB()

    def initDB(self):
        pass
        querys = [
            """drop database if exists moneytaker;""",
            """create database moneytaker
            default character set utf8
            default collate utf8_general_ci;""",
            """use moneytaker;""",
            """CREATE TABLE mt_user
            (
                `idx`    INT             NOT NULL    AUTO_INCREMENT, 
                `id`     VARCHAR(45)     NOT NULL, 
                `pw`     VARCHAR(256)    NOT NULL, 
                `token`  VARCHAR(256)    NOT NULL, 
                `class`  VARCHAR(45)     NULL, 
                PRIMARY KEY (idx)
            )ENGINE=InnoDB
            default character set utf8
            default collate utf8_general_ci;""",
            """CREATE TABLE mt_group
            (
                `gidx`   INT            NOT NULL    AUTO_INCREMENT, 
                `name`   VARCHAR(45)    NOT NULL, 
                `state`  VARCHAR(45)    NULL, 
                PRIMARY KEY (gidx)
            )ENGINE=InnoDB
            default character set utf8
            default collate utf8_general_ci;""",
            """CREATE TABLE mt_iou
            (
                `ridx`          INT               NOT NULL    AUTO_INCREMENT, 
                `date`          TIMESTAMP         NOT NULL, 
                `borrower_idx`  INT               NOT NULL, 
                `lender_idx`    INT               NOT NULL, 
                `start_date`    DATETIME          NULL, 
                `end_date`      DATETIME          NULL, 
                `cost`          DECIMAL(18, 0)    NOT NULL, 
                `state`         INT               NULL, 
                PRIMARY KEY (ridx)
            )ENGINE=InnoDB
            default character set utf8
            default collate utf8_general_ci;""",
            """ALTER TABLE mt_iou ADD CONSTRAINT FK_mt_iou_borrower_idx_mt_user_idx FOREIGN KEY (borrower_idx)
             REFERENCES mt_user (idx)  ON DELETE RESTRICT ON UPDATE RESTRICT;""",
            """ALTER TABLE mt_iou ADD CONSTRAINT FK_mt_iou_lender_idx_mt_user_idx FOREIGN KEY (lender_idx)
             REFERENCES mt_user (idx)  ON DELETE RESTRICT ON UPDATE RESTRICT;""",
            """CREATE TABLE mt_friendlist
            (
                `gidx`        INT    NOT NULL, 
                `idx`         INT    NOT NULL, 
                `friend_idx`  INT    NOT NULL, 
                `credit`      INT    NULL, 
                PRIMARY KEY (idx, friend_idx)
            )ENGINE=InnoDB
            default character set utf8
            default collate utf8_general_ci;""",
            """ALTER TABLE mt_friendlist ADD CONSTRAINT FK_mt_friendlist_gidx_mt_group_gidx FOREIGN KEY (gidx)
             REFERENCES mt_group (gidx)  ON DELETE RESTRICT ON UPDATE RESTRICT;""",
            """ALTER TABLE mt_friendlist ADD CONSTRAINT FK_mt_friendlist_idx_mt_user_idx FOREIGN KEY (idx)
             REFERENCES mt_user (idx)  ON DELETE RESTRICT ON UPDATE RESTRICT;""",
            """ALTER TABLE mt_friendlist ADD CONSTRAINT FK_mt_friendlist_friend_idx_mt_user_idx FOREIGN KEY (friend_idx)
             REFERENCES mt_user (idx)  ON DELETE RESTRICT ON UPDATE RESTRICT;""",
            """CREATE TABLE mt_grouplist
            (
                `idx`         INT    NOT NULL, 
                `gidx`        INT    NOT NULL, 
                `permission`  INT    NULL, 
                PRIMARY KEY (idx, gidx)
            )ENGINE=InnoDB
            default character set utf8
            default collate utf8_general_ci;""",
            """ALTER TABLE mt_grouplist ADD CONSTRAINT FK_mt_grouplist_idx_mt_user_idx FOREIGN KEY (idx)
             REFERENCES mt_user (idx)  ON DELETE RESTRICT ON UPDATE RESTRICT;""",
            """ALTER TABLE mt_grouplist ADD CONSTRAINT FK_mt_grouplist_gidx_mt_group_gidx FOREIGN KEY (gidx)
             REFERENCES mt_group (gidx)  ON DELETE RESTRICT ON UPDATE RESTRICT;"""
        ]
        for query in querys:
            self.query(query);

    def connect(self):
        self.conn = pymysql.connect(host="localhost",
                                    user="root",
                                    password="root",
                                    db="moneyTaker",
                                    autocommit=True,
                                    cursorclass=pymysql.cursors.DictCursor)

    def query(self, query):
        # Connection 으로부터 Cursor 생성
        self.connect()
        result = {}
        try:
            with self.conn.cursor() as cursor:
                cursor.execute(query)
                result = cursor.fetchall()
        finally:
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