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
        public bool isLegalWord(Automaton automaton,string inputText)
        {
            State beginState = findInitialState(automaton.AutomatonStates); 
            foreach (char c in inputText)
            {
              

            }

            return false;
        }

        public State findInitialState(StateSet states)
        {
            foreach (var state in states.StoredStates)
            {
                if (state.IsBeginState)
                {
                    return state;
                }
            }

            return null;
        }

        public StateSet returnPossibleDestinationState(char c,StateSet inputSet)
        {
            StateSet outputSet = new StateSet();
            foreach (State state in inputSet.StoredStates)
            {
                foreach (var transition in state.Neighbours)
                {
                    if (transition.InputCharacter == c)
                    {
                        outputSet.add(transition.DestinationState);
                    }
                }
            }

            return outputSet;
        }
    }
   
}
