using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.DotnetProj1
{
    internal class Student
    {
        public int sid;
        public string sname;
        public static string collegename = "Chennai IIIT";
        public const int semester = 6;

        public Student(int sid, string sname)
        {
            this.sid = sid;
            this.sname = sname;
        }
    }
}
