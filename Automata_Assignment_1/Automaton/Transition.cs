using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automaton
{
    public class Transition
    {
        private State InitialState { get; }
        private State DestinationState { get; }
        private char InputCharacter { get; }

        public Transition(State initialState,State destinationState,char inputCharacter)
        {
            InitialState = initialState;
            DestinationState = destinationState;
            InputCharacter = inputCharacter;
        }
        
    }
}
