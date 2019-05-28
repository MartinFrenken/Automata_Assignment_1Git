using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public class StateSet
    {
        
        public List<State> StoredStates { get; private set; } = new List<State>();
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
            UnhandlePrevious();
            StateSet output = new StateSet();
            while (this.ContainsEpsilon())
            {
                CorrectForEpsilonOnce();
            }
            return this;
        }

        private void CorrectForEpsilonOnce()
        {
            if (ContainsEpsilon())
            {
                foreach (State state in this.StoredStates.ToList())
                {

                    foreach (var transition in state.Neighbours)
                    {
                        if (transition.InputCharacter == '_' && !transition.HandledForEpsilon)
                        {
                            transition.HandledForEpsilon = true;
                            if(!StoredStates.Contains(transition.DestinationState))
                            StoredStates.Add(transition.DestinationState);

                        }
                    }
                }
            }

        }

        public HashSet<State> ConvertToHash(StateSet stateSet)
        {
            HashSet<State> output = new HashSet<State>();
            foreach (State state in stateSet.StoredStates)
            {
                output.Add(state);
            }
            return output;
        }
        public StateSet ConvertHashToStateSet(HashSet<State>stateSet)
        {
            StateSet output = new StateSet();
            foreach (State state in stateSet)
            {
                output.add(state);
            }
            return output;
        }
        public bool ContainsEpsilon()
        {
            foreach (State state in this.StoredStates)
            {
          
                foreach (var transition in state.Neighbours)
                {
                    if (transition.InputCharacter == '_'&&!transition.HandledForEpsilon)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool UnhandlePrevious()
        {
            foreach (State state in this.StoredStates)
            {

                foreach (var transition in state.Neighbours)
                {
                    if (transition.InputCharacter == '_' && transition.HandledForEpsilon)
                    {
                        transition.HandledForEpsilon = false;
                    }
                }
            }
            return false;
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

