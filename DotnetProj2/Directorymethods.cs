using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.DotnetProj2
{
    internal class Directorymethods
    {
        public void Directoryfunc()
        {
            DirectoryInfo d;
            d = new DirectoryInfo(@"D:\4570\Notes\Backend\Filesprac");
            Console.WriteLine("Exists: " + d.Exists);

            if (d.Exists)
            {
                Console.WriteLine("Fullname : " + d.FullName);
                Console.WriteLine("Name : " + d.Name);
                Console.WriteLine("Directory Name : " + d.Parent);
                Console.WriteLine("Creation Date and Time : " + d.CreationTime);
                Console.WriteLine("Modification date and time: " + d.LastWriteTime);
                Console.WriteLine("Access date and time: " + d.LastAccessTime);

                FileInfo[] files = d.GetFiles();
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.Name);
                }

                DirectoryInfo[] directories = d.GetDirectories();
                for (int i = 0; i < directories.Length; i++)
                {
                    Console.WriteLine(directories[i].Name);
                }
            }


            if (Directory.Exists(@"D:\4570\Notes\Backend\Filesprac\Csharp") == true)
            {
                Directory.Delete(@"D:\4570\Notes\Backend\Filesprac\Csharp", true);
            }


            Directory.CreateDirectory(@"D:\4570\Notes\Backend\Filesprac\Csharp");
            Console.WriteLine("CSharp created");
            Console.WriteLine("CSharp exists: " + Directory.Exists(@"D:\4570\Notes\Backend\Filesprac\Csharp"));

            Directory.CreateDirectory(@"D:\4570\Notes\Backend\Filesprac\Csharp2");
            //Directory.Move(@"D:\4570\Notes\Backend\Filesprac\Csharp", @"D:\4570\Notes\Backend\Filesprac\C2"); //Rename directory

            File.Create(@"D:\4570\Notes\Backend\Filesprac\Csharp\file1.txt").Close();
            Console.WriteLine("File created");
            File.Copy(@"D:\4570\Notes\Backend\Filesprac\Csharp\file1.txt", @"D:\4570\Notes\Backend\Filesprac\Csharp\file2.txt");
            Console.WriteLine("File created");
            File.Move(@"D:\4570\Notes\Backend\Filesprac\Csharp\file2.txt", @"D:\4570\Notes\Backend\Filesprac\Csharp\file3.txt");
            Console.WriteLine("File moved");
            Console.WriteLine("File exists: " + File.Exists(@"D:\4570\Notes\Backend\Filesprac\Csharp\file3.txt"));
        }

        public void FilesWrite()
        {
            FileInfo f = new FileInfo(@"D:\4570\Notes\Backend\Filesprac\C2\file1.txt");
            if (f.Exists == true)
                f.Delete();
            //create the file
            FileStream fs = new FileStream(@"D:\4570\Notes\Backend\Filesprac\C2\file1.txt", FileMode.Create, FileAccess.Write);

            //write data to the file
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hai");
            sw.WriteLine("Hello");
            sw.WriteLine("How are you");
            //close the file
            sw.Close();
            Console.WriteLine("Written");


            FileInfo fss = new FileInfo(@"D:\4570\Notes\Backend\Filesprac\C2\file1.txt");
            if (fss.Exists == true)
            {
                //open the file

                FileStream fsss = new FileStream(@"D:\4570\Notes\Backend\Filesprac\C2\file1.txt", FileMode.Open, FileAccess.Read);
                //read the file
                StreamReader sr = new StreamReader(fsss);
                string s = sr.ReadToEnd();
                //close the file
                sr.Close();
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
