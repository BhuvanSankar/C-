using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace P3new1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "P3newWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select P3newWCF.svc or P3newWCF.svc.cs at the Solution Explorer and start debugging.
    public class P3newWCF : IP3newWCF
    {
        public List<Book> GetAllBooks()
        {
            List<Book> booklist = null;
            try
            {
                booklist = new List<Book>();
                string file = @"C:\sankar\books.txt";
                char[] deli = { ',' };
                string line;
                FileStream F = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader lines = new StreamReader(F);
                while ((line = lines.ReadLine()) != null)
                {
                    Book book = new Book();
                    string[] sta = line.Split(deli);
                    book.ID = sta[0];
                    book.name = sta[1];
                    book.author = sta[2];
                    int y = Convert.ToInt32(sta[3]);
                    book.year = y;
                    string p1 = sta[4].Replace("$", "");
                    float p2 = float.Parse(p1);
                    book.price = p2;
                    string s1 = sta[5];
                    int s = Convert.ToInt32(s1);
                    book.stock = s;
                    booklist.Add(book);
                }
                lines.Close();
                 
            }
            
            catch
            {

            }
            return booklist.ToList(); 
        }



        public Boolean AddBook(string ID, string name, string author, int year, float price, int stock)
        {
            string newbk = ID + "," + name + "," + author + "," + year + "," + "$" + price + "," + stock;
            string same = ID + "," + name + "," + author + "," + year + "," + "$" + price;
            
            try
            {
                string file = @"C:\sankar\books.txt";
                var original = File.ReadAllLines(file);
                var updated = new List<string>();
                int check = 0;
                foreach (var line in original)
                {
                    string[] infos = line.Split(',');
                    string inf = infos[0] + "," + infos[1] + "," + infos[2] + "," +infos[3] + "," + infos[4];                 
                    if (inf == same)
                    {
                        int s = Convert.ToInt32(infos[5]);
                        string s1 = (s + stock).ToString();
                        infos[5] = s1;
                        check = check+1;
                    }
                    updated.Add(string.Join(",", infos));

                }
                File.WriteAllLines(file, updated);


                if (check == 0)
                {
                    FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write);
                    StreamWriter ls = new StreamWriter(fs);
                    ls.WriteLine(newbk);
                    ls.Close();
                    GetAllBooks();
                }

                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public Boolean DeleteBook(string dropkey, string textkey)
        {
            try
            {
                
                
                int N = 0;
                int Y = 0;
                string id = "";
                string sl = "";
                if (dropkey == "Num")
                {
                    N = Convert.ToInt32(textkey);
                }
                if (dropkey == "ID")
                {
                    id = textkey;
                }
                if (dropkey == "Year")
                {
                    Y = Convert.ToInt32(textkey);
                }
                //if(dropkey == "Select")
               // {
                  //  sl = textkey;
               // }


                string nl = "";
                string file = @"C:\sankar\books.txt";
                char[] deli = { ',' };
                string line;
                int count = 0;
                FileStream F = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader lines = new StreamReader(F);
                while ((line = lines.ReadLine()) != null)
                {
                    string[] sta = line.Split(deli);                    
                    int yr = Convert.ToInt32(sta[3]);    
                

                    if (Y != 0)
                    {
                        if (Y != yr)
                        {
                            nl += line + Environment.NewLine;
                        }

                    }

                    else if (id != "")
                    {
                        if (sta[0] != id)
                        {
                            nl += line + Environment.NewLine;
                        }

                    }

                    else if (N != 0)
                    {
                        if ((N-1) != count)
                        {
                            nl += line + Environment.NewLine;
                        }

                    }

                    else
                    {

                         nl += line + Environment.NewLine;
                    }
                   
                    count += 1;

                }
                lines.Close();
                File.WriteAllText(file, nl);
                return true;
            }
            catch (Exception ae)
            {
                return false;
                throw ae;
            }
                  
        }


        public List<Book> SearchBook(string dropkey, string textkey)
        {
            List<Book> booklist = null;
            try
            {
                booklist = new List<Book>();
                string nm = "";
                int Y = 0;
                string id = "";
                string ar = "";
                if (dropkey == "Name")
                {
                    nm = textkey;
                }
                if (dropkey == "ID")
                {
                    id = textkey;
                }
                if (dropkey == "Year")
                {
                    Y = Convert.ToInt32(textkey);
                }
                if (dropkey == "Author")
                {
                    ar = textkey;
                }


                //string nl = "";
                string file = @"C:\sankar\books.txt";
                char[] deli = { ',' };
                string line;
                
                FileStream F = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader lines = new StreamReader(F);
                while ((line = lines.ReadLine()) != null)
                {
                    Book book = new Book();
                    string[] sta = line.Split(deli);
                    book.ID = sta[0];
                    book.name = sta[1];
                    book.author = sta[2];
                    int yr = Convert.ToInt32(sta[3]);
                    book.year = yr;
                    string p1 = sta[4].Replace("$", "");
                    float p2 = float.Parse(p1);
                    book.price = p2;
                    string s1 = sta[5];
                    int s = Convert.ToInt32(s1);
                    book.stock = s;
                    //booklist.Add(book);
                    string stu1 = sta[1].ToUpper();
                    string nmu = nm.ToUpper();
                    string stu2 = sta[2].ToUpper();
                    string aru = ar.ToUpper();

                    if (Y != 0)
                    {
                        if (Y == yr)
                        {
                            booklist.Add(book);
                        }

                    }
                    else if (nm != "")
                    {
                        if (nm == sta[1] || stu1.Contains(nmu))
                        {   
                         
                            booklist.Add(book);
                        }
                    }
                    else if (id != "")
                    {
                        if (id == sta[0])
                        {
                            booklist.Add(book);
                        }
                    }
                    else if (ar != "" )
                    {
                        if (ar == sta[2] || stu2.Contains(aru))
                        {
                            booklist.Add(book);
                        }
                    }

                }
                lines.Close();
               
            }
            catch 
            {
                
            }        
            return booklist.ToList();
            
        }
        //public BookPurchaseResponse bpr(BookPurchaseInfo bpi)
        //{

        //}

        public float budget(int k, int v)
        {
            float r = 0.000f;
            return r;
        }
        



        public void DoWork()
        {
        }

        public int Yr { get; set; }
    }
}
