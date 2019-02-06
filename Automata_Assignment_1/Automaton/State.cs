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
        public bool IsEndState { get; }

        public State(string stateName)
        {
            StateName = stateName;
            IsBeginState = false;
            IsEndState = false;
        }
        public State(string stateName,bool ce)
        {
            StateName = stateName;
            IsBeginState = false;
            IsEndState = false;
        }
    }
}
