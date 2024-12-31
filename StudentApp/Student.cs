using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student : Person, IAddress ,IContact
    {
        public int rollno {  get; set; }
        public string pname { get; set; }
        public char gender { get; set; }
        public static int id = 1;

        public string City { get; set; }
        public string State { get; set; }
        public long ZipCode {  get; set; }

        public long mobile { get; set; }
        public string email { get; set; }
        public static int incrementID()
        {
           return id++;
        }
        public void showDetails()
        {
            Console.WriteLine("Student Details");
            if(rollno > 0)
            {
                Console.WriteLine("Roll no: " + rollno);
            }
            if (pname != "")
            {
                Console.WriteLine("Name of Student" + pname);
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

        //public void displayDetails(int rollno = 0, string sname = " ", char gender = ' ')
        //{
        //    Console.WriteLine("Details");
        //    if (rollno > 0)
        //    {
        //        Console.WriteLine("Roll no: " + rollno);
        //    }
        //    if (sname != "")
        //    {
        //        Console.WriteLine("Name of Student" + sname);
        //    }
        //    if (gender != ' ')
        //    {
        //        Console.WriteLine("Gender : " + gender);
        //    }
        //}
    }
}
