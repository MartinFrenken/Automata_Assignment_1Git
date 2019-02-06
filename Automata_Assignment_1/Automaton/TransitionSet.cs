using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automaton
{
    public class TransitionSet
    {
        private List<Transition> StoredStates { get; }
        void add(Transition transition)
        {
            StoredStates.Add(transition);
        }
    }
}
