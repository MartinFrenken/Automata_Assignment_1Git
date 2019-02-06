using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automaton
{
    public class State
    {
        private string StateName { get; }
        private bool IsBeginState { get; }
        private bool IsEndState { get; }

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
