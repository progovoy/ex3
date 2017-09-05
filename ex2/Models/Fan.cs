using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ex2.Models
{
    public class Fan
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int YearsInClub { get; set; }

        public Fan()
        {
            this.FirstName = "X";
            this.LastName = "X";
            this.YearsInClub = 0;
            this.Gender = 'X';
            this.BirthDate = new DateTime();
        }

        public Fan(string first, string last, char Gender, int years)
        {
            this.FirstName = first;
            this.LastName = last;
            this.YearsInClub = years;
            this.Gender = Gender;
            this.BirthDate = DateTime.Now;
        }
    }

    public class FanDBContext : DbContext
    {
        public DbSet<Fan> Fans { get; set; }
    }
}