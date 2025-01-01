using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.DotnetProj2
{
    internal class Filemethods
    {
        public void Filefunc()
        {
            FileInfo f;
            f = new FileInfo(@"D:\\4570\\Notes\\Backend\\sample.txt");
            Console.WriteLine("Exists: "+f.Exists);

            if (f.Exists) 
            {
                Console.WriteLine("Fullname: " + f.FullName);
                Console.WriteLine("Name: " + f.Name);
                Console.WriteLine("DirectoryName: " + f.DirectoryName);
                Console.WriteLine("Extension: " + f.Extension);
                Console.WriteLine("Creation Time and Date: " + f.CreationTime);
                Console.WriteLine("Modification Time and Date: " + f.LastWriteTime);
                Console.WriteLine("Access Date and Time: " + f.LastAccessTime);
                Console.WriteLine("Length: " + f.Length + " bytes");
            }

        }
    }
}
