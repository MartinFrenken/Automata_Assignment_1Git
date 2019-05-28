using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    class FiniteLanguageAnalyzer
    {
        public Automaton subjectAutomaton  { get; private set; }
        public FiniteLanguageAnalyzer(Automaton automaton)
        {
            this.subjectAutomaton = automaton;
        }

        public bool isFiniteLanguage()
        {
            StateSet automatonStates = subjectAutomaton.AutomatonStates;
            if (!subjectAutomaton.isDeterministic())
                return false;
            foreach(State state in automatonStates.StoredStates)
            {
                if (CanReachItself(state))
                    return false;
                if (state.StateName!="Sink"&&!CanReachEndState(state))
                    return false;
            }
            return true;
        }
        public bool CanReachItself(State state)
        {
            ISet<String> handledStates = new HashSet<String>();
            Queue<State> statesToHandle = new Queue<State>();
            statesToHandle.Enqueue(state);
            while (statesToHandle.Count > 0)
            {
                State dequeuedState = statesToHandle.Dequeue();
                foreach (Transition transition in dequeuedState.Neighbours)
                {
                    String currentStateName = transition.DestinationState.StateName;
                    if (!handledStates.Contains(currentStateName))
                    {
                        statesToHandle.Enqueue(transition.DestinationState);
                        handledStates.Add(currentStateName);
                    }
                    else if(state.StateName==currentStateName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool CanReachEndState(State state)
        {
            ISet<String> handledStates = new HashSet<String>();
            Queue<State> statesToHandle = new Queue<State>();
            statesToHandle.Enqueue(state);
            while (statesToHandle.Count > 0)
            {
                State dequeuedState = statesToHandle.Dequeue();
                if (subjectAutomaton.getFinalState().StateName == dequeuedState.StateName)
                    return true;

               foreach (Transition transition in dequeuedState.Neighbours)
               {
                    String currentStateName = transition.DestinationState.StateName;
                    if (!handledStates.Contains(currentStateName))
                    {
                        if (currentStateName != "Sink")
                        {
                            statesToHandle.Enqueue(transition.DestinationState);
                            handledStates.Add(currentStateName);
                        }
                       
                    }
                    if (subjectAutomaton.getFinalState().StateName == currentStateName&&currentStateName!="Sink")
                    {
                        return true;
                    }
               }
            }
            return false;
        }
    }
}
