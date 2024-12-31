using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Faculty : Person, IAddress, IContact
    {
        //public int rollno { get; set; }
        public string pname { get; set; }
        public char gender { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long ZipCode { get; set; }

        public long mobile { get; set; }
        public string email { get; set; }
        
        public void showDetails()
        {
            Console.WriteLine("Faculty Details");
            //if (rollno > 0)
            //{
            //    Console.WriteLine("Roll no: " + rollno);
            //}
            if (pname != "") 
            {
                Console.WriteLine("Name of Faculty : " + pname);
            }
            if (gender != ' ')
            {
                Console.WriteLine("Gender : " + gender);
            }
        }

        public string getAddress()
        {
            return $"Address is City : {City} , State : {State}, Pincode : {ZipCode}";
        }

        public string showContact()
        {
            return $"Contact : {mobile} , Email : {email}";
        }
    }
}
