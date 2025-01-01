using demodotnet.DotnetProj2;
using demodotnet.StudentApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet
{
    internal class Program
    {
        public delegate int scalc(int a, int b);
        private static void Main(string[] args)
        {
            //EmployeeDetails empobj = new EmployeeDetails();
            //empobj.EmployeeMenu();
            //ExceptionHandling eh = new ExceptionHandling();
            //eh.ExceptionMethod();

            //scalc d;
            //Calculate c = new Calculate();
            //d = c.Sum;
            //d = c.Sub;
            //d(220, 20);

            //Subscriber s = new Subscriber();
            //s.doWork();

            //Counter.Increment ci = new Counter.Increment();
            //ci.doIncrement();

            //Filemethods f = new Filemethods();
            //f.Filefunc();

            Directorymethods dm = new Directorymethods();
            //dm.Directoryfunc();
            dm.FilesWrite();
        }
    }
}
