using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automaton
{
    public class Transition
    {

        public State DestinationState { get; }
        public string InputAlphabet { get; }

        public Transition(string inputAlphabet,State destinationState)
        {
           
            DestinationState = destinationState;
            InputAlphabet = inputAlphabet;
        }
        
    }
}
