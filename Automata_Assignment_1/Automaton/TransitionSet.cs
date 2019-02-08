using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automaton
{
    public class TransitionSet
    {
        public List<Transition> StoredTransitions { get; }
        void add(Transition transition)
        {
            StoredTransitions.Add(transition);
            
        }
    }
}
