using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.DotnetProj1
{
    //OOPS Demo 
    internal class Company
    {
        private int cid;
        private string cname;

        public Company(int id, string name)
        {
            cid = id;
            cname = name;
        }

        public void displayCompanyDetails()
        {
            Console.WriteLine("Company Registration number:" + cid);
            Console.WriteLine("Company Name : " + cname);
        }
    }
}
