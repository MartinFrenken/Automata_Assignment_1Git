using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1
{
    public class Alphabet
    {
        public List<char> characters { get; } = new List<char>();
        public void Add(char letter)
        {
            characters.Add(letter);
        }

    }
}
