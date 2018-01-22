using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace newprac2
{
    /// <summary>
    /// Summary description for prac2form1service2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class prac2form1service2 : System.Web.Services.WebService
    {
        [WebMethod]
        public string zodfinder(string n, string m)
        {
            int n1 = int.Parse(n);
            int n2 = int.Parse(m);
            string s3 = "Day Out of Range";
            if (n1 == 1)
            {
                if (n2 >= 1 && n2 <= 20)
                {
                    string s1 = "Capricon";
                    return s1;
                }
                else if (n2 >= 21 && n2 <= 31)
                {
                    string s2 = "Aquarius";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 2)
            {
                if (n2 >= 1 && n2 <= 19)
                {
                    string s1 = "Aquarius";
                    return s1;
                }
                else if (n2 >= 20 && n2 <= 29)
                {
                    string s2 = "Pisces";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 3)
            {
                if (n2 >= 1 && n2 <= 20)
                {
                    string s1 = "Pisces";
                    return s1;
                }
                else if (n2 >= 21 && n2 <= 31)
                {
                    string s2 = "Aries";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 4)
            {
                if (n2 >= 1 && n2 <= 20)
                {
                    string s1 = "Aries";
                    return s1;
                }
                else if (n2 >= 21 && n2 <= 30)
                {
                    string s2 = "Taurus";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 5)
            {
                if (n2 >= 1 && n2 <= 21)
                {
                    string s1 = "Taurus";
                    return s1;
                }
                else if (n2 >= 22 && n2 <= 31)
                {
                    string s2 = "Gemini";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 6)
            {
                if (n2 >= 1 && n2 <= 21)
                {
                    string s1 = "Gemini";
                    return s1;
                }
                else if (n2 >= 22 && n2 <= 30)
                {
                    string s2 = "Cancer";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 7)
            {
                if (n2 >= 1 && n2 <= 22)
                {
                    string s1 = "Cancer";
                    return s1;
                }
                else if (n2 >= 23 && n2 <= 31)
                {
                    string s2 = "Leo";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 8)
            {
                if (n2 >= 1 && n2 <= 22)
                {
                    string s1 = "Leo";
                    return s1;
                }
                else if (n2 >= 23 && n2 <= 31)
                {
                    string s2 = "Virgo";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 9)
            {
                if (n2 >= 1 && n2 <= 23)
                {
                    string s1 = "Virgo";
                    return s1;
                }
                else if (n2 >= 24 && n2 <= 30)
                {
                    string s2 = "Libra";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 10)
            {
                if (n2 >= 1 && n2 <= 23)
                {
                    string s1 = "Libra";
                    return s1;
                }
                else if (n2 >= 24 && n2 <= 31)
                {
                    string s2 = "Scorpio";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 11)
            {
                if (n2 >= 1 && n2 <= 22)
                {
                    string s1 = "Scorpio";
                    return s1;
                }
                else if (n2 >= 23 && n2 <= 30)
                {
                    string s2 = "Sagittarius";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else if (n1 == 12)
            {
                if (n2 >= 1 && n2 <= 21)
                {
                    string s1 = "Sagittarius";
                    return s1;
                }
                else if (n2 >= 22 && n2 <= 31)
                {
                    string s2 = "Capricon";
                    return s2;
                }
                else
                {
                    return s3;
                }
            }
            else
            {
                string s2 = "Month Out of Range";
                return s2;
            }
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
