using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

internal static class ClarifyManager
{
    public static bool IsEmail(string email)
    {
        Regex regex = new Regex(@"^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$");
        return regex.IsMatch(email);
    }

    public static bool IsSQLInjection(string text)
    {
        Regex regex = new Regex("('(''|[^'])*')|(['\"\\-#()@;=*/+])|(\b(ALTER|CREATE|DELETE|DROP|EXEC(UTE){0,1}|INSERT( +INTO){0,1}|MERGE|SELECT|UPDATE|UNION( +ALL){0,1})\b)");
        return regex.IsMatch(text);
    }
    public static bool IsName(string name)
    {
        Regex regex = new Regex(@"^([0-9a-zA-Zㄱ-ㅎㅏ-ㅣ가-힣]){3,}$");
        return regex.IsMatch(name);
    }
}