using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commision { get; set; }
        public Vendor(string fname, string lname, double commision)
        {
            FirstName = fname;
            LastName = lname;
            Commision = commision;
        }
    }
}
