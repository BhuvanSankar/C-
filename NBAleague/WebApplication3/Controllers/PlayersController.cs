using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;





namespace WebApplication3.Controllers
{
    public class PlayersController : ApiController
    {
        public List<Players> ReadPlayers()
        {
            List<Players> playerlist = null;

            try
            {
                playerlist = new List<Players>();
                string file = @"C:\sankar\players.txt";
                char[] deli = { ',' };
                string line;
                FileStream F = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader lines = new StreamReader(F);
                while ((line = lines.ReadLine()) != null)
                {
                    Players player = new Players();
                    string[] sta = line.Split(deli);
                    player.RegistrationID = sta[0];
                    player.FirstName = sta[1];
                    player.LastName = sta[2];
                    player.TeamName = sta[3];
                    player.DateOfBirth = Convert.ToDateTime(sta[4]);
                    playerlist.Add(player);
                }
                lines.Close();
            }
            catch
            {

            }
            return playerlist.ToList();
           
           
        }

        
        public IHttpActionResult GetAllPlayers()
        {
            return Ok(ReadPlayers());
        }


        public IHttpActionResult GetPlayer(string tb, string dp)
        {
            List<Players> playerlist = null;

            try
            {
                playerlist = new List<Players>();
                string nm = "";
                string id = "";

                if (dp == "Name")
                {
                    nm = tb;
                }
                if (dp == "ID")
                {
                    id = tb;
                }


                string file = @"C:\sankar\players.txt";
                char[] deli = { ',' };
                string line;

                FileStream F = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader lines = new StreamReader(F);
                while ((line = lines.ReadLine()) != null)
                {
                    Players player = new Players();
                    string[] sta = line.Split(deli);
                    DateTime date = DateTime.Parse(sta[4]);
                    player.RegistrationID = sta[0];
                    player.FirstName = sta[1];
                    player.LastName = sta[2];
                    player.TeamName = sta[3];
                    player.DateOfBirth = date.Date;


                    
                    string full = (sta[1] + " " + sta[2]).ToUpper();                    
                    string nmu = nm.ToUpper();


                    if (nm != "")
                    {
                        if (full.Contains(nmu) || nmu == full )
                        {
                            playerlist.Add(player);
                        }
                    }
                    else if (id != "")
                    {
                        if (id == sta[0])
                        {
                            playerlist.Add(player);
                        }
                    }


                }
                lines.Close();
            }
            catch
            {

            }

            return Ok(playerlist.ToList());
        }


        
        public IHttpActionResult DeletePlayer(string tb1, string dp1)
        {
            List<Players> playerlist = null;
            string nl = "";
            try
            {
                string id = " ";
                string nm = " ";
                if (dp1 == "ID" || dp1 == "Name")
                {
                    if (dp1 == "ID")
                    {
                        id = tb1;
                    }
                    if (dp1 == "Name")
                    {
                        nm = tb1;
                    }


                    string file = @"C:\sankar\players.txt";
                    char[] deli = { ',' };
                    string line;
                    FileStream F = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader lines = new StreamReader(F);
                    while ((line = lines.ReadLine()) != null)
                    {
                        string[] sta = line.Split(deli);

                        if (id != " ")
                        {
                            if (sta[0] != id)
                            {
                                nl += line + Environment.NewLine;
                            }
                        }
                        else if (nm != " ")
                        {
                            string full = (sta[1] + " " + sta[2]).ToUpper();
                            string nmu = nm.ToUpper();

                            if (!full.Contains(nmu))
                            {
                                nl += line + Environment.NewLine;
                            }

                        }
                        else
                        {
                            nl += line + Environment.NewLine;
                        }

                    }
                    lines.Close();
                    File.WriteAllText(file, nl);

                    playerlist = new List<Players>();
                    string line1;
                    FileStream F1 = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader lines1 = new StreamReader(F1);
                    while ((line1 = lines1.ReadLine()) != null)
                    {
                        Players player = new Players();
                        string[] sta1 = line1.Split(deli);
                        player.RegistrationID = sta1[0];
                        player.FirstName = sta1[1];
                        player.LastName = sta1[2];
                        player.TeamName = sta1[3];
                        player.DateOfBirth = Convert.ToDateTime(sta1[4]);
                        playerlist.Add(player);
                    }
                    lines1.Close();
                }

            }

            catch
            {

            }
            return Ok(playerlist.ToList());

        }

        //Add or Update Player
        public IHttpActionResult PostPlayer(string id, string fn, string ln, string tn, DateTime dob)
        {
            string newline = id + "," + fn + "," + ln + "," + tn + "," + dob;
            //var udl = new List<string>();
            //int ct = 0;
            try
            {
                string file = @"C:\sankar\players.txt";
                var original = File.ReadAllLines(file);
                var updated = new List<string>();
                int count = 0;
                foreach (var line in original)
                {
                    string[] infos = line.Split(',');
                    if (infos[0] == id)
                    {
                        infos[1] = fn;
                        infos[2] = ln;
                        infos[3] = tn;
                        infos[4] = dob.ToString();
                        count = count + 1;

                    }
                    updated.Add(string.Join(",", infos));

                }
                File.WriteAllLines(file, updated);

                if (count == 0)
                {
                    FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write);
                    StreamWriter ls = new StreamWriter(fs);                    
                    ls.WriteLine(newline);
                    ls.Close();
                    
                }
            }

            catch
            {

            }

            return Ok(ReadPlayers());
        }
    }
}
