using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public class PowerState:State
    {
        public StateSet States { get; private set; }
  
    public PowerState(StateSet states)
        {
            this.States = states;
            this.StateName = "";
            States = states;
            List<String> stateNames = new List<string>();
            foreach (var state in states.StoredStates)
            {
                stateNames.Add(state.StateName);
                if (state.IsEndState)
                    this.IsEndState = true;
            }
            stateNames.Sort();
            foreach (String s in stateNames)
            {
                this.StateName = this.StateName +s;
            }
        }
       
    }
}
