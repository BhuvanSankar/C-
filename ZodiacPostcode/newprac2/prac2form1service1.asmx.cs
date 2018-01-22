using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace newprac2
{
    /// <summary>
    /// Summary description for prac2form1service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class prac2form1service1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string datefinder(string n) 
        {
            string s = "NOT FOUND";
            if (n == "aries" )
            {
                string s1 = "03/21 - 04/20";
                return s1;
            }
            else if (n=="taurus")
            {
                string s2 = "04/21 - 05/21";
                return s2;
            }
            else if (n == "gemini")
            {
                string s3 = "05/22 - 06/21";
                return s3;
            }
            else if (n == "cancer")
            {
                string s4 = "06/22 - 07/22";
                return s4;
            }
            else if (n == "leo")
            {
                string s5 = "07/23 - 08/22";
                return s5;
            }
            else if (n == "virgo")
            {
                string s6 = "08/23 - 09/23";
                return s6;
            }
            else if (n == "libra")
            {
                string s7 = "09/24 - 10/23";
                return s7;
            }
            else if (n == "scorpio")
            {
                string s8 = "10/24 - 11/22";
                return s8;
            }
            else if (n == "sagittarius")
            {
                string s9 = "11/23 - 12/21";
                return s9;
            }
            else if (n == "capricorn")
            {
                string s10 = "12/22 - 01/20";
                return s10;
            }
            else if (n == "aquarius")
            {
                string s11 = "01/21 - 02/19";
                return s11;
            }
            else if (n == "pisces")
            {
                string s12 = "02/20 - 03/20";
                return s12;
            }                
            else
            {
                return s;
            }
                

        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
