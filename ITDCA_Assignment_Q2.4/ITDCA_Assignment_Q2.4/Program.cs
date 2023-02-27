using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRepeatedWordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word;
            Console.WriteLine("Type the sentence below");
            Word = Console.ReadLine();     
            var Value = Word.Split(' ');   

            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();

            for (int i = 0; i < Value.Length; i++) 
            {
                if (RepeatedWordCount.ContainsKey(Value[i])) 
                {
                    int value = RepeatedWordCount[Value[i]];
                    RepeatedWordCount[Value[i]] = value + 1;
                }
                else
                {
                    RepeatedWordCount.Add(Value[i], 1);   
                }
            }
            Console.WriteLine();
            Console.WriteLine("___________________________________");
            Console.WriteLine("Repeated words and counts:\n");
            foreach (KeyValuePair<string, int> kvp in RepeatedWordCount.OrderBy(key => key.Key))
            {
                Console.WriteLine(kvp.Key + " Counts: " + kvp.Value);  
            }

                Console.ReadKey();

            
        }
    }
}
