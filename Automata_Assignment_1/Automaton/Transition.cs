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
        public char InputCharacter { get; }

        public Transition(char inputCharacter,State destinationState)
        {
           
            DestinationState = destinationState;
            InputCharacter = inputCharacter;
        }
        
    }
}
