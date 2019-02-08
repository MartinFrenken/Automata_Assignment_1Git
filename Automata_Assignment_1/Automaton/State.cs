using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automaton
{
    public class State
    {
        public string StateName { get; }
        public bool IsBeginState { get; }
        public bool IsEndState { private set;get; }
        public List<Transition> Neighbours { get; } = new List<Transition>();

        public State(string stateName)
        {
            StateName = stateName;
            IsBeginState = false;
            IsEndState = false;
        }
        public State(string stateName,bool isBeginState)
        {
            StateName = stateName;
            IsBeginState = isBeginState;
            IsEndState = false;
        }
      
        public void AddTransition(Transition transition)
        {
            Neighbours.Add(transition);
        }

        public void SetEndState()
        {
            IsEndState = false;
        }
    }
}
