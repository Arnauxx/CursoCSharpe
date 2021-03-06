using System;
using System.IO;
using System.Collections.Generic;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string sourcePath = @"C:\Users\arnau\source\repos\CursoCSharpe\file1.txt";
            string targetPath = @"C:\Users\arnau\source\repos\CursoCSharpe\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

            */
            /*
            string path = @"C:\Users\arnau\source\repos\CursoCSharpe\file1.txt";
           // FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }


            }

            catch(IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message );
            }
            finally
            {
                if (sr != null) sr.Close();
             //   if (fs != null) fs.Close();
            }

            */
            /*
            string path = @"C:\Users\arnau\source\repos\CursoCSharpe\file1.txt";
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            */

            /*
            string sourcePath = @"C:\Users\arnau\source\repos\CursoCSharpe\file1.txt";
            string targetPath = @"C:\Users\arnau\source\repos\CursoCSharpe\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }

            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

            */
            /*
            string path = @"c:\temp\MyFolder";

            try
            {
               IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folder)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newfolder");

            }

            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            */

            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());




        }
    }
}
