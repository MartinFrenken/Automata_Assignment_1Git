using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public class State
    {
        public string StateName { get; protected set; }
        public bool IsBeginState { get; protected set; }
        public bool IsEndState { protected set;get; }
        public List<Transition> Neighbours { get; } = new List<Transition>();
        public bool IsDone = false;
        public State()
        {
            IsBeginState = false;
            IsEndState = false;
        }
        public void setBeginState()
        {
            IsBeginState = true;
        }
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

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                State s = (State) obj;
                return (s.StateName == this.StateName);
            }
        }

        public void AddTransition(Transition transition)
        {
            Neighbours.Add(transition);
        }

        public void SetEndState()
        {
            IsEndState = true;
        }


    }
}
