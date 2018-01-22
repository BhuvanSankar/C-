using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newprac2
{
    public partial class prac2webform1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r;
            string z = TextBox1.Text.ToLower();
            ServiceReference1.prac2form1service1SoapClient service = new ServiceReference1.prac2form1service1SoapClient();
            r = service.datefinder(z);
            TextBox2.Text = r;            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string mon;
            string s = TextBox3.Text;
            string d = TextBox4.Text;
            ServiceReference2.prac2form1service2SoapClient service = new ServiceReference2.prac2form1service2SoapClient();
            mon = service.zodfinder(s, d);
            TextBox5.Text = mon;            
                
        }
    }
}