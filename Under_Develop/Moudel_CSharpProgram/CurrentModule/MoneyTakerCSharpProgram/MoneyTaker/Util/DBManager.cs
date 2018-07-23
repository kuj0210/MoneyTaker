using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MoneyTaker
{
    public class DBManager
    {
        private string strConn = "Server=" + DBConfig.SERVER +
                ";Database=" + DBConfig.DB +
                ";Uid=" + DBConfig.ID +
                ";Pwd=" + DBConfig.PASSWORD +
                ";Charset=utf8";

        private MySqlConnection conn;

        public DBManager()
        {
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public bool InsertRegisterData(String email, String password)
        {
            if (ExistUserEmail(email))
                return false;
            else
            {
                //패스워드 암호화하여 DB에 전송
                password = new EncryptTool().Encrypt(password);

                MySqlCommand cmd = new MySqlCommand("INSERT INTO User VALUES ('', '" + email + "', '" + password + "')", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public bool ExistUserEmail(String email)
        {
            foreach (DataRow r in Select("User", "Email = '" + email + "'").Tables[0].Rows)
            {
                if (email.Equals(r["Email"].ToString()))
                    return true;
            }

            return false;
        }

        public DataSet Select(String table, String sqlWord)
        {
            DataSet dataSet = new DataSet();
            string sql = "SELECT * FROM " + table + " WHERE " + sqlWord;
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);

            adpt.Fill(dataSet, table);

            return dataSet;
        }

    }
}