using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public class StateSet
    {
        public List<State> StoredStates { get; } = new List<State>();
        public void add(State state)
        {
           
            StoredStates.Add(state);
            
        }

        public void add(StateSet stateSet)
        {
            foreach (var state in stateSet.StoredStates)
            {
                add(state);
            }
        }
        public static void test() 
        {
        }
    }
}
