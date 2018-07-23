using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTaker
{
    public class RegistryManager
    {

        RegistryKey reg;

        public RegistryManager()
        {
            reg = Registry.CurrentUser.CreateSubKey(Propertise.APPNAME);
        }

        public void SetAutoLogin(bool key)
        {
            reg.SetValue("AutoLogin", key);
        }

        public bool IsAutoLogin()
        {
            try
            {
                if (((String)reg.GetValue("AutoLogin")).Equals("True")) return true;
                else return false;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public void SetEmail(String key)
        {
            reg.SetValue("Email", key);
        }

        public String GetEmail()
        {
            try
            {
                return (String)reg.GetValue("Email");
            }
            catch (Exception e)
            {
                return "";
            }
        }

    }
}