using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>()
            {
                {"nahida",2},
                {"popy",3},
                {"sultana",4}
            };
            foreach (KeyValuePair<string, int> pair in d)
            {
                Console.WriteLine("{0},{1}",
                pair.Key,pair.Value);
            }
            // Use var keyword to enumerate dictionary
        

            Console.ReadKey();
        }
    }
}
