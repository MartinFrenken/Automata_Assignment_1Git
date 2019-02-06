using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automaton
{
    public class StateSet
    {
        private List<State> StoredStates { get; }
        void add(State state)
        {
            StoredStates.Add(state);
        }
    }
}
