using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public class StateSet
    {
        
        public List<State> StoredStates { get; } = new List<State>();
        public void add(State state)
        {
           
            StoredStates.Add(state);
            
        }

        public void add(StateSet stateSet)
        {
            foreach (var state in stateSet.StoredStates)
            {
                add(state);
            }
        }
        public static void test() 
        {
        }
        public static StateSet initializeStateSet(State inputState)
        {
            StateSet outputSet = new StateSet();
            outputSet.StoredStates.Add(inputState);


            return outputSet;
        }
        public  State findInitialState()
        {
            foreach (var state in this.StoredStates)
            {
                if (state.IsBeginState)
                {
                    return state;
                }
            }

            return null;
        }


        public  StateSet CorrectForEpsilon()
        {
            StateSet outputSet = new StateSet();
            foreach (State state in this.StoredStates)
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

        public  StateSet returnPossibleDestinationStates(char c)
        {
            StateSet outputSet = new StateSet();
            
            foreach (State state in this.StoredStates)
            {
                foreach (var transition in state.Neighbours)
                {
                    if (transition.InputCharacter == c && state.StateName!="Sink")
                    {
                        outputSet.add(transition.DestinationState);
                    }
                }
            }

            return outputSet;
        }
        public  bool containsFinalState(StateSet inputStateSet, Automaton automaton)
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

