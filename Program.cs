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
            char delimiter = ' ';
            string[] wordsArray = userInput.Split(delimiter);

            foreach (string str in wordsArray)
                Console.WriteLine(str);
        }
    }
}
