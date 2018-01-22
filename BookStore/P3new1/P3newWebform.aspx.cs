using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.IO;

namespace P3new1
{
    public partial class P3newWebform : System.Web.UI.Page
    {
        ServiceReference1.P3newWCFClient bks = new ServiceReference1.P3newWCFClient();


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                heading1();
                newtable1(); 
            }
                   
            
            //GetbooksPanel.Visible = true;         
             

        }

        private void heading1()
        {
            TableRow bookrow = new TableRow();
            TableCell bookcell1 = new TableCell();
            bookcell1.Text = "Num";
            bookrow.Cells.Add(bookcell1);
            TableCell bookcell2 = new TableCell();
            bookcell2.Text = "ID";
            bookrow.Cells.Add(bookcell2);
            TableCell bookcell3 = new TableCell();
            bookcell3.Text = "Name";
            bookrow.Cells.Add(bookcell3);
            TableCell bookcell4 = new TableCell();
            bookcell4.Text = "Author";
            bookrow.Cells.Add(bookcell4);
            TableCell bookcell5 = new TableCell();
            bookcell5.Text = "Year";
            bookrow.Cells.Add(bookcell5);
            TableCell bookcell6 = new TableCell();
            bookcell6.Text = "Price";
            bookrow.Cells.Add(bookcell6);
            TableCell bookcell7 = new TableCell();
            bookcell7.Text = "Stock";
            bookrow.Cells.Add(bookcell7);
            Table1.Rows.Add(bookrow);
        }

        private void heading2()
        {
            TableRow bookrow = new TableRow();
            TableCell bookcell1 = new TableCell();
            bookcell1.Text = "Num";
            bookrow.Cells.Add(bookcell1);
            TableCell bookcell2 = new TableCell();
            bookcell2.Text = "ID";
            bookrow.Cells.Add(bookcell2);
            TableCell bookcell3 = new TableCell();
            bookcell3.Text = "Name";
            bookrow.Cells.Add(bookcell3);
            TableCell bookcell4 = new TableCell();
            bookcell4.Text = "Author";
            bookrow.Cells.Add(bookcell4);
            TableCell bookcell5 = new TableCell();
            bookcell5.Text = "Year";
            bookrow.Cells.Add(bookcell5);
            TableCell bookcell6 = new TableCell();
            bookcell6.Text = "Price";
            bookrow.Cells.Add(bookcell6);
            TableCell bookcell7 = new TableCell();
            bookcell7.Text = "Stock";
            bookrow.Cells.Add(bookcell7);
            Table2.Rows.Add(bookrow);
        }


        private void newtable1()
        {
            
            int bookcount = bks.GetAllBooks().Count;
            

            for (int i = 0; i < bookcount; i++)
            {
                TableRow brow = new TableRow();
                TableCell bcell1 = new TableCell();
                bcell1.Text = (i + 1).ToString();
                brow.Cells.Add(bcell1);
                TableCell bcell2 = new TableCell();
                bcell2.Text = bks.GetAllBooks()[i].ID;
                brow.Cells.Add(bcell2);
                TableCell bcell3 = new TableCell();
                bcell3.Text = bks.GetAllBooks()[i].name;
                brow.Cells.Add(bcell3);
                TableCell bcell4 = new TableCell();
                bcell4.Text = bks.GetAllBooks()[i].author;
                brow.Cells.Add(bcell4);
                TableCell bcell5 = new TableCell();
                int y1 = bks.GetAllBooks()[i].year;
                bcell5.Text = (y1).ToString();
                brow.Cells.Add(bcell5);
                TableCell bcell6 = new TableCell();
                float p1 = bks.GetAllBooks()[i].price;
                bcell6.Text = "$" + (p1).ToString();
                brow.Cells.Add(bcell6);
                TableCell bcell7 = new TableCell();
                int s1 = bks.GetAllBooks()[i].stock;
                bcell7.Text = s1.ToString();
                brow.Cells.Add(bcell7);
                Table1.Rows.Add(brow);

            }

            
        }

        private void newtable2()
        {
            string skey = TextBox8.Text;
            string dkey = DropDownList2.SelectedItem.Value;  

            int bookcount = bks.SearchBook(dkey, skey).Count;

            for (int i = 0; i < bookcount; i++)
            {
                TableRow brow = new TableRow();
                TableCell bcell1 = new TableCell();
                bcell1.Text = (i + 1).ToString();
                brow.Cells.Add(bcell1);
                TableCell bcell2 = new TableCell();
                bcell2.Text = bks.SearchBook(dkey,skey)[i].ID;
                brow.Cells.Add(bcell2);
                TableCell bcell3 = new TableCell();
                bcell3.Text = bks.SearchBook(dkey, skey)[i].name;
                brow.Cells.Add(bcell3);
                TableCell bcell4 = new TableCell();
                bcell4.Text = bks.SearchBook(dkey, skey)[i].author;
                brow.Cells.Add(bcell4);
                TableCell bcell5 = new TableCell();
                int y1 = bks.SearchBook(dkey, skey)[i].year;
                bcell5.Text = (y1).ToString();
                brow.Cells.Add(bcell5);
                TableCell bcell6 = new TableCell();
                float p1 = bks.SearchBook(dkey, skey)[i].price;
                bcell6.Text = "$" + (p1).ToString();
                brow.Cells.Add(bcell6);
                TableCell bcell7 = new TableCell();
                int s1 = bks.SearchBook(dkey, skey)[i].stock;
                bcell7.Text = s1.ToString();
                brow.Cells.Add(bcell7);
                Table2.Rows.Add(brow);

            }
        }



      protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                int flg = 0;
                string newid = TextBox1.Text;
                string newname = TextBox2.Text;
                string newauthor = TextBox3.Text;
                string nyear = TextBox4.Text;
                int newyear = Convert.ToInt32(nyear);
                string nprice = TextBox5.Text;
                float newprice = float.Parse(nprice);
                string nstock = TextBox6.Text;
                int newstock = Convert.ToInt32(nstock);
                int texts;

                string pattern1 = @"^[0-9]*$";
                Regex regex1 = new Regex(pattern1);
                if (regex1.IsMatch(newid) == false)
                {
                    flg = 1;
                }

                string pattern2 = @"^[a-zA-Z |\.]*$";
                Regex regex2 = new Regex(pattern2);
                if (regex2.IsMatch(newname) == false)
                {
                    flg = 1;
                }

                string pattern3 = @"^[a-zA-Z |\.]*$";
                Regex regex3 = new Regex(pattern3);
                if (regex3.IsMatch(newauthor) == false)
                {
                    flg = 1;
                }

                string pattern4 = @"^[0-9]*$";
                Regex regex4 = new Regex(pattern4);
                if (regex4.IsMatch(nyear) == false)
                {
                    flg = 1;
                }
                else if (newyear > 2015)
                {
                    TextBox4.Text = "Please Enter Valid Year";
                    flg = 1;
                }

                string pattern5 = @"^[0-9]*(?:\.[0-9]*)?$";
                Regex regex5 = new Regex(pattern5);
                if (regex5.IsMatch(nprice) == false)
                {
                    flg = 1;
                }

                string pattern6 = @"^[1-9]\d*$";
                Regex regex6 = new Regex(pattern6);
                if (regex6.IsMatch(nstock) == false)
                {
                    flg = 1;
                }

                
                //GetbooksPanel.Visible = false;
                if (flg == 0) {

                    bks.AddBook(newid, newname, newauthor, newyear, newprice, newstock);

                }
                heading1();
                newtable1();
                // GetbooksPanel.load = true;
            }
            catch
            {
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter a valid Data');", true);
                heading1();
                newtable1();
            }    
            
   

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int flg = 0;
                string dropkey = DropDownList1.SelectedItem.Value;
                string textkey = TextBox7.Text;
                int tex;
                int bookcount = bks.GetAllBooks().Count;
                if(dropkey=="Num")
                {
                    string pattern1 = @"^[1-9]*$";
                    Regex regex1 = new Regex(pattern1);
                    if (regex1.IsMatch(textkey) == false)
                    {
                        flg = 1;
                    }
                    else if ((tex = Convert.ToInt32(textkey)) > bookcount)
                    {
                        TextBox7.Text = "Out of Range";
                        flg = 1;
                    }
                    
                }
                if (dropkey == "ID")
                {
                    string pattern2 = @"^[0-9]*$";
                    Regex regex2 = new Regex(pattern2);
                    if (regex2.IsMatch(textkey) == false)
                    {
                        flg = 1;
                    }
                }
                if (dropkey == "Year")
                {
                    string pattern3 = @"^[0-9]*$";
                    Regex regex3 = new Regex(pattern3);
                    if (regex3.IsMatch(textkey) == false)
                    {
                        flg = 1;
                    }

                   
                }
                //|| 
                //GetbooksPanel.Visible = true;
                if (flg == 0)
                {
                    bks.DeleteBook(dropkey, textkey);
                }
                heading1();
                newtable1();
                
                //this.Page_Load(null, null);
                //GetbooksPanel.Visible = true;

            }
            catch
            {
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter a valid Data');", true);
                heading1();
                newtable1();
            } 
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            heading1();
            newtable1();
            try
            {
                string key1 = DropDownList2.SelectedItem.Value;
                string key2 = TextBox8.Text;
                int st = bks.SearchBook(key1, key2).Count;
                //int st = bs.SearchBooks(sr).Count;                

                if (key2 != "")
                {
                    if (st == 0)
                    {
                        TextBox8.Text = "No Results, Please try again!";

                    }
                    else
                    {
                        heading2();
                        newtable2();
                    }
                    
                }       
            }
            catch
            {
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter a valid Data');", true);
                heading1();
                newtable1();
            } 
            
                        
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}