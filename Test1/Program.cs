using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Dropbox\Text\arcadia show 2017 schedule.txt";
            string ArcadiaFile = File.ReadAllText(@"C:\Dropbox\Text\arcadia show 2017 schedule.txt");
            if (ArcadiaFile.Contains("!"))
            {
                ArcadiaFile = ArcadiaFile.Replace("!", "marklar!!!!!!!!!!! hahahahah i am writing to a file ya mafkas!");

                File.WriteAllText(path, ArcadiaFile);
                Console.WriteLine(ArcadiaFile);
                

            }
            else
            {
                Console.Write("yabbish, theres nothin.");
            }
            
            Console.ReadLine();

        }
    }
}
