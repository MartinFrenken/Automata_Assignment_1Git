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
        State sink;
        Queue<PowerState> powerStateQueue = new Queue<PowerState>();
        List<String> handledStates = new List<string>();
        public AutomatonGenerator(Automaton inputAutomaton)
        {
            automaton = inputAutomaton;
            sink = GenerateSink(automaton.Alphabet);

        }

        public Automaton GenerateDfa()
        {
            StateSet output = new StateSet();

            StateSet initialStates = GetInitialStates(automaton.AutomatonStates);
            PowerState initialPowerState = new PowerState(initialStates);
            handledStates.Add(initialPowerState.StateName);
            powerStateQueue.Enqueue(initialPowerState);
            while (powerStateQueue.Count > 0)
            {
               PowerState newPowerState = powerStateQueue.Dequeue();
                addNeighbouringPowerStates(newPowerState);
                output.add(newPowerState);
            }
           
      
            return new Automaton(output,automaton.Alphabet);




        }


        StateSet addNeighbouringPowerStates(PowerState powerState)
        {
            StateSet output = new StateSet();
            State newPowerState;
                foreach (char c in automaton.Alphabet.characters)
                {
                StateSet stateSet = new StateSet();
                    foreach (State state in powerState.States.StoredStates)
                    {
                       foreach (Transition transition in state.Neighbours)
                       {
                            if (transition.InputCharacter == c )
                            {
                                stateSet.add(transition.DestinationState);
                            }
                       }
                    }
                //StateSet stateSetToAdd = stateSet.CorrectForEpsilon();
                if (stateSet.StoredStates.Count > 0)
                {
                    stateSet = stateSet.CorrectForEpsilon();
                    newPowerState = new PowerState(stateSet);
                    PowerState powerStateToEnqueue = new PowerState(stateSet);
                    if (!handledStates.Contains(powerStateToEnqueue.StateName))
                    {
                        powerStateQueue.Enqueue(powerStateToEnqueue);
                        handledStates.Add(powerStateToEnqueue.StateName);
                    }
                    else
                    {
                        int x = 1;//debug purposes on ly
                    }
                }
                else
                    newPowerState = sink;

                powerState.AddTransition(new Transition(c, newPowerState));
        
                }

            return output;
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
