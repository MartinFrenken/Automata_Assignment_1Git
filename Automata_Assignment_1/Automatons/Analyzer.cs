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
            int endStates = 0;
            foreach (State state in states)
            {
                if (state.IsEndState)
                {
                    endStates++;
                }

                List<char> inputsForTransitions = new List<char>();
                foreach (Transition transition in state.Neighbours)
                {
                    inputsForTransitions.Add(transition.InputCharacter);
                    if (transition.InputCharacter == '_')
                    {
                        return false;
                    }
                }
                if (!automaton.Alphabet.characters.All(inputsForTransitions.Contains))
                {      
                    return false;
                }
                if (automaton.Alphabet.characters.Count() != inputsForTransitions.Count())
                {
                    return false;
                }
            }

            if (endStates==0)
            {
                return false;
            }

            return true;
        }
       
    }
}
