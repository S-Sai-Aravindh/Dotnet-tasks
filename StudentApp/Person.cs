using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal interface Person
    {
        public string pname { get; set; }
        public char gender { get; set; }

        void showDetails();
    }
}
