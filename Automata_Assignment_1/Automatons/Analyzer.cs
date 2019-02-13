using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public class Analyzer
    {
        public bool isDfa(Automaton automaton)
        {
            List<State> states = automaton.AutomatonStates.StoredStates;

            foreach (State state in states)
            {
                List<char> inputsForTransitions = new List<char>();
                foreach (Transition transition in state.Neighbours)
                {
                    inputsForTransitions.Add(transition.InputCharacter);
                }
                if (automaton.Alphabet.characters.All(inputsForTransitions.Contains))
                {
                    return true;
                }
                
            }
            return false;
        }
       
    }
}
