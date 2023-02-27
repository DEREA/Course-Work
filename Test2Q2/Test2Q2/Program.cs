using System;
using System.IO;
namespace Test2Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\k254l\source\repos\Test2Q2";

            if (File.Exists(path)) 
            {
                File.Delete(path);
            }
            
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();

            StreamWriter sw;
            sw = File.CreateText(@"C:\Users\k254l\source\repos\Test2Q2\\MyFile.txt");



            for (int i = 0; i< 5;i++) 
            {
                sw.Write(name+",");
            }
            
            sw.Close();

            string text = File.ReadAllText(path);
            string phrase = text;

            string[] words = phrase.Split(',');

            for(int i = 0; i < words.Length; i++)
            {
                System.Console.WriteLine(words[i]);
            }


        }
    }
}
