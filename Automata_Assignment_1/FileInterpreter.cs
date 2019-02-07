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
        string currentLine;
        

        public FileInterpreter()
        {
        
        }
        public void readFile()
        {
            currentLine = sr.ReadLine();
            while (currentLine != null)
            { 

                Console.WriteLine(currentLine);
                if (currentLine.StartsWith(ls.Comment))
                {
                    Console.WriteLine("That was a commment!");
                }
                else if (currentLine.StartsWith(ls.Alphabet))
                {
                    generateAlphabet();
                }
                currentLine = sr.ReadLine();
                
            }
        }
        void generateAlphabet()
        {
            Alphabet alphabet = new Alphabet();
            string trimmedOne =currentLine.Replace(ls.Alphabet, "");
            string trimmedTwo =currentLine.Trim(' ');
            Console.WriteLine("Trimmed version: "+trimmedTwo);
            foreach (char c in trimmedTwo)
            {
                alphabet.Add(c);
                Console.WriteLine("Added something!");
            }
        }

    }
}
