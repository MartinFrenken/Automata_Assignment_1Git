using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public class Automaton
    {
        public  StateSet AutomatonStates { get; }
        public Alphabet Alphabet { get; }
        public Automaton(StateSet states,Alphabet alphabet)
        {
            AutomatonStates=states;
            Alphabet = alphabet;

        }

     
        
    }
}
