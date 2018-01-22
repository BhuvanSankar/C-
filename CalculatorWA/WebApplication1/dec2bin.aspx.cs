using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class dec2bin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TextBox1.Text);
            int y = int.Parse(TextBox2.Text);
            int z=0;
            if(DropDownList1.SelectedValue == "/" && y == 0)
            {
                TextBox3.Text = "ZERO DIVISION ERROR";
                TextBox4.Text = "ZERO DIVISION ERROR";
            }
            else
            {
                switch (DropDownList1.SelectedValue)
                {
                    case "+":
                        z = x + y;
                        break;
                    case "-":
                        z = x - y;
                        break;
                    case "*":
                        z = x * y;
                        break;
                    case "/":
                        z = x / y;
                        break;
                    default:
                        break;
                }
                TextBox3.Text = z.ToString();
                int a = int.Parse(TextBox3.Text);
                TextBox4.Text = Convert.ToString(a, 2);     
            }
                   
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            int count0 = 0, count1 = 0;
            int y = int.Parse(TextBox2.Text);
            if (DropDownList1.SelectedValue == "/" && y == 0)
            {
                TextBox5.Text = " ";
                TextBox6.Text = " ";
            }
            else
            {
                foreach (char s in TextBox4.Text)
                {
                    if (s == '0')
                        count0++;
                    else
                        count1++;
                }
                TextBox5.Text = count0.ToString();
                TextBox6.Text = count1.ToString();
            }
            
        }
    }
}