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
        Automaton automaton;
        public AutomatonGenerator(Automaton inputAutomaton)
        {
            automaton = inputAutomaton;
            
          
        }

        public Automaton GenerateDfa()
        {
            //Get initial states
            StateSet initialStates = GetInitialStates(automaton.AutomatonStates);
            PowerState initialPowerState = new PowerState(initialStates);

            getNeighbouringPowerStates(initialPowerState);

            StateSet output = new StateSet();
            output.add(initialPowerState);
            

            return new Automaton(output,automaton.Alphabet);




        }


        List<PowerState> getNeighbouringPowerStates(PowerState powerState)
        {
            State newPowerState;
                foreach (char c in automaton.Alphabet.characters)
                {
                StateSet stateSet = new StateSet();
                    foreach (State state in powerState.States.StoredStates)
                    {
                       foreach (Transition transition in state.Neighbours)
                       {
                            if (transition.InputCharacter == c)
                            {
                            stateSet.add(transition.DestinationState);
                            }
                       }
                    }
                //StateSet stateSetToAdd = stateSet.CorrectForEpsilon();
                if (stateSet.StoredStates.Count > 0)
                    newPowerState = new PowerState(stateSet);
                else
                    newPowerState = GenerateSink(automaton.Alphabet);

                powerState.AddTransition(new Transition(c, newPowerState));
                }
          
            return null;
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

        private StateSet GetInitialStates(StateSet stateSet)
        {
            StateSet output = new StateSet();
            StateSet s = stateSet;
            output.add(s.findInitialState());
            output= output.CorrectForEpsilon();
            return output;
        }




    }
}
