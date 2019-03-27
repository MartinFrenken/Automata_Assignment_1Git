using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public class AutomatonGenerator
    {
        public AutomatonGenerator()
        {
            
            
          
        }

        public Automaton GenerateDfa(Automaton inputAutomaton)
        {


            StateSet inputAutomatonStates = inputAutomaton.AutomatonStates;
            var alphabet = inputAutomaton.Alphabet;
            HashSet<State> outputStates = new HashSet<State>();
            State Sink = GenerateSink(alphabet);
            foreach (var state in inputAutomatonStates.StoredStates)
            {
                foreach (var character in alphabet.characters)
                {

                    StateSet stateSetForNewPowerState = new StateSet();
                    State newState = new State();
                    foreach (var transition in state.Neighbours)
                    {
                        if (transition.InputCharacter==character)
                        stateSetForNewPowerState.add(transition.DestinationState);
                    }


                    if (stateSetForNewPowerState.StoredStates.Count > 1)
                    {
                        newState = new PowerState(stateSetForNewPowerState);  
                    }

                    else if (stateSetForNewPowerState.StoredStates.Count == 0)
                    {
                        //newState 
                    }
                    else
                    {
                        newState = stateSetForNewPowerState.StoredStates.ElementAt(0);
                    }


                    outputStates.Add(newState);

                }
            }

            var Debug = outputStates;

            return inputAutomaton;




        }

       

        private State GenerateSink(Alphabet alphabet)
        {
            State outputState = new State("Sink");
            foreach (var character in alphabet.characters)
            {
                Transition newTransition = new Transition(character,outputState);
                outputState.AddTransition(newTransition);
            }

            return outputState;
        }



    }
}
