using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public class Transition
    {

        public State DestinationState { get; }
        public bool HandledForEpsilon = false;
        public char InputCharacter { get; }

        public Transition(char inputAlphabet,State destinationState)
        {
           
            DestinationState = destinationState;
            InputCharacter = inputAlphabet;
        }
        
    }
}
