using System;
using System.IO;
using System.Text.RegularExpressions;

namespace file_name_reading
{
    class ReadFileData
    {
        static void Main(string[] args)
        {
            //String[] fileName = Directory.GetFiles(@"C:\MyPractice\DemoFolder","*.json");

            String[] fileName = Directory.GetFiles(@"C:\MyPractice\DemoFolder\", "*.json",SearchOption.AllDirectories);
            //String[] newNames=null;
           
            for(int i = 0; i < fileName.Length; i++)
            {
                Console.WriteLine(fileName[i]);
                
                String text = System.IO.File.ReadAllText(fileName[i]);
                Console.WriteLine(text);

                String n = Regex.Replace(fileName[i], @" ", "");
                Console.WriteLine(n);   
            }
        }
    }
}

