using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.StudentApp
{
    internal class Employee
    {
        public int eid { get; set; }
        public string ename { get; set; }

        public Employee(int eid, string ename)
        {
            eid = eid;
            ename = ename;
        }
    }
}
