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
            StateSet initialStateSet= new StateSet();
            StateSet currentStateSet= new StateSet();
            initialStateSet = initializeStateSet(beginState);
            currentStateSet = CorrectForEpsilon(initialStateSet);
            for (int i = 0;i<inputText.Length;i++)
            {

                StateSet previousStateSet = currentStateSet;
               currentStateSet = returnPossibleDestinationStates(inputText.ElementAt(i), CorrectForEpsilon(currentStateSet));
                currentStateSet = CorrectForEpsilon(currentStateSet);
            }
            
            if (containsFinalState(currentStateSet,automaton))
            {
                return true;
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
        

        public StateSet returnPossibleDestinationStates(char c,StateSet inputSet)
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
        
        public StateSet CorrectForEpsilon(StateSet inputSet)
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
        public StateSet initializeStateSet( State inputState)
        {
            StateSet outputSet = new StateSet();
            outputSet.StoredStates.Add(inputState);
            

            return outputSet;
        }

        public bool containsFinalState(StateSet inputStateSet,Automaton automaton)
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
