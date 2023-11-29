using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L26_split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "Если бы, да кабы, да во рту росли грибы";
            string[] stringArray = userInput.Split(' ');

            foreach (string str in stringArray)
                Console.WriteLine(str);
        }
    }
}
