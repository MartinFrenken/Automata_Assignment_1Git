using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Automata_Assignment_1
{
    public class FileInterpreter
    {
        static string fileLocation = "D:\\automata.txt";
        LanguageSyntax ls = new LanguageSyntax();
        StreamReader sr = new StreamReader(fileLocation);
        public FileInterpreter()
        {
            string firstWord = sr.ReadLine();
            Console.WriteLine(firstWord);
        }
        

    }
}
