using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTaker
{
    public class EncryptTool
    {

        private static readonly String cryptKey = "ri83js0d";


        byte[] Skey = new byte[8];

        public EncryptTool()
        {
            Skey = ASCIIEncoding.ASCII.GetBytes(cryptKey);
        }

        public string Encrypt(string p_data)
        {
            if (Skey.Length != 8)
            {
                throw (new Exception("Invalid key. Key length must be 8 byte."));
            }
            DESCryptoServiceProvider rc2 = new DESCryptoServiceProvider();
            rc2.Key = Skey;
            rc2.IV = Skey;
            MemoryStream ms = new MemoryStream();
            CryptoStream cryStream = new CryptoStream(ms, rc2.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] data = Encoding.UTF8.GetBytes(p_data.ToCharArray());
            cryStream.Write(data, 0, data.Length);
            cryStream.FlushFinalBlock();

            return Convert.ToBase64String(ms.ToArray());
        }

        public string Decrypt(string p_data)
        {
            DESCryptoServiceProvider rc2 = new DESCryptoServiceProvider();

            rc2.Key = Skey;
            rc2.IV = Skey;

            MemoryStream ms = new MemoryStream();
            CryptoStream cryStream = new CryptoStream(ms, rc2.CreateDecryptor(), CryptoStreamMode.Write);
            byte[] data = Convert.FromBase64String(p_data);

            cryStream.Write(data, 0, data.Length);
            cryStream.FlushFinalBlock();

            return Encoding.UTF8.GetString(ms.GetBuffer());
        }
    }
}