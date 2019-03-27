using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public static class SetOperations
    {
        public static StateSet initializeStateSet(State inputState)
        {
            StateSet outputSet = new StateSet();
            outputSet.StoredStates.Add(inputState);
            

            return outputSet;
        }
        public static State findInitialState(StateSet states)
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
        public static StateSet CorrectForEpsilon(StateSet inputSet)
        {
            StateSet outputSet = new StateSet();
            foreach (State state in inputSet.StoredStates)
            {
                outputSet.add(state);
                foreach (var transition in state.Neighbours)
                {
                    if (transition.InputCharacter == '_')
                    {
                        outputSet.add(transition.DestinationState);
                    }
                }
            }

            return outputSet;
        }

        public static StateSet returnPossibleDestinationStates(char c, StateSet inputSet)
        {
            StateSet outputSet = new StateSet();
            foreach (State state in inputSet.StoredStates)
            {
                foreach (var transition in state.Neighbours)
                {
                    if (transition.InputCharacter == c && state.StateName != "Sink")
                    {
                        outputSet.add(transition.DestinationState);
                    }
                
                }
            }

            return outputSet;
        }
        public static bool containsFinalState(StateSet inputStateSet, Automaton automaton)
        {
            List<State> finalStates = new List<State>();

            foreach (State state in automaton.AutomatonStates.StoredStates)
            {
                if (state.IsEndState)
                {
                    finalStates.Add(state);
                }


            }

            foreach (State state in inputStateSet.StoredStates)
            {
                foreach (State finalState in finalStates)
                {
                    if (finalState.StateName == state.StateName)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
