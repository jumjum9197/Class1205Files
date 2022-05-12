using System;
using System.IO;
using System.Text;

namespace Class1205Files
{
     class Program
    {
        static void Main(string[] args)
        {
            ////directoryinfo
            //DirectoryInfo dir = new DirectoryInfo(".");
            //DirectoryInfo direc = new DirectoryInfo(@"C:\Users\MY PC\Desktop");
            //Console.WriteLine(direc.Name);
            //Console.WriteLine(direc.FullName);
            //Console.WriteLine(direc.Parent);
            //Console.WriteLine(direc.CreationTime);
            //Console.WriteLine(dir.Name);


            //file
            //string[] words = { "this is a ball", " this is a house", "set a chalk", "mice" };
            //string path = @"C:\Users\MY PC\Desktop\file to work on\jummy.txt";
            //File.WriteAllLines(path, words);

            //foreach(var word in File.ReadAllLines(path))
            //{
            //    Console.WriteLine(word);
            //}

            //string[] word = { "this is a ball", " this is a house", "set a chalk", "mice" };
            //string paths = @"C:\Users\MY PC\Desktop\file to work on\jummy.doc";
            //File.WriteAllLines(paths, word);

            //foreach (var item in File.ReadAllLines(paths))
            //{
            //    Console.WriteLine(item);
            //}
           

            
        
            ////Filesinfo =
            //DirectoryInfo dit = new DirectoryInfo(@"C:\Users\MY PC\Desktop\SHEKONI BUKOLA");
            //    FileInfo[] testfile =  dit.GetFiles("*.txt", SearchOption.AllDirectories);
            //Console.WriteLine("mathes : {0}", testfile.Length);

            //foreach (FileInfo file in testfile)
            //{
            //    Console.WriteLine(file.FullName);
            //    Console.WriteLine(file.CreationTime);
            //}

            ////screamWriter
            //StreamWriter sw = new StreamWriter(@"C:\Users\MY PC\Desktop\file to work on\jummy.txt");
            //sw.WriteLine("welcome to cyberspace");
            //sw.WriteLine("pleasue to meet you");
            //sw.Close();


            ////readfor all
            //StreamReader rw = new StreamReader(@"C:\Users\MY PC\Desktop\file to work on\jummy.txt");
            //Console.WriteLine(rw.ReadToEnd());
            //rw.Close();



            //filestream        write

            string path4 = @"C:\Users\MY PC\Desktop\file to work on\jummy.txt";
            FileStream fs =  File.Open(path4, FileMode.Create);
            string network = "this is a brand new car";


            byte [] buffer = Encoding.Default.GetBytes(network);
            fs.Write(buffer, 0, buffer.Length); 

            fs.Position = 0;
            //filestream read
            byte[] filelist = new byte[buffer.Length];
            for(int i = 0; i < buffer.Length; i++)
            {
                filelist[i] = (byte)fs.ReadByte();
            }
          
            

            Console.WriteLine(Encoding.Default.GetString(filelist));
            fs.Close();
                
        }


    }
}
