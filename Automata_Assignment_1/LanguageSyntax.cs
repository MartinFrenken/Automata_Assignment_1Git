using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1
{
    public class LanguageSyntax
    {
        public  string Comment { get; } = "#";
        public  string Alphabet { get; } = "alphabet:";
        public  string StateCollection { get; } = "states:";
        public string FinalStateCollection { get; } = "final:";
        public string Arrow { get; } = "-->";
        public string Endline { get; } = "end.";
    }
}
