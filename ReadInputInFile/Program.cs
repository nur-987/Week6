using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInputInFile
{
    /// <summary>
    /// Read input from a text file which contains (a-z, A-Z, 0-9)  calculate occurance of each char in the file
    /// Write output of the number of occurance in another file.
    /// </summary>
    class Program
    {
        public static Dictionary<char, int> dict = new Dictionary<char, int>();

        static void Main(string[] args)
        {
            Creating();
            Reading();
            CreatingNew();

        }

        public static void Creating()
        {
            FileStream fs = new FileStream("InputFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fs);
            Console.WriteLine("Enter text");
            var str = Console.ReadLine();
            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();

        }

        public static void Reading()
        {
            FileStream fs = new FileStream("InputFile.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd();
            string newStr = str.Replace(" ", string.Empty);

            foreach (char chr in newStr)
            {
                if (dict.ContainsKey(chr))
                {
                    dict[chr] = dict[chr] + 1;

                }
                else
                {
                    dict.Add(chr, 1);
                }
            }
            Console.WriteLine("completed occurence calculation");

            
        }

        public static void CreatingNew()
        {
            FileStream fs = new FileStream("OutputFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fs);

            //foreach (var item in dict.Keys)
            foreach(KeyValuePair<char,int> kvp in dict)
            {
                //streamWriter.WriteLine(item + "=" + dict[item]);
                streamWriter.WriteLine(kvp);
            }
            Console.WriteLine("printed result in Output.txt file");
            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();
        }
    }
}
