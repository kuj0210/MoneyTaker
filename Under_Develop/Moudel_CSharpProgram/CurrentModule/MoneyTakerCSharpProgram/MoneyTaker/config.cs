using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTaker
{

    public class Propertise
    {

        private static String documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

        public static readonly String APPNAME = "MoneyTaker";
        // 임시 데이터 보관용 XML.
        public static readonly String MODEL_PATH = documentPath + "\\MoneyTaker\\data.xml";
    }
    
    //TODO : 나중에 EmailManager 내부에서 관리할 유저 이메일.
    public class USERConfig
    {
        public static String EMAIL = "";
    }

    public class SMTPConfig
    {
        public static readonly String ID = "여기에 구글 이메일";
        public static readonly String PASSWORD = "여기에 구글 패스워드";
    }

    public class DBConfig
    {
        public static readonly String SERVER = "여기에 서버 IP.";
        public static readonly String DB = "MoneyTaker";
        public static readonly String ID = "MoneyTaker";
        public static readonly String PASSWORD = @"여기에 패스워드";
    }
}