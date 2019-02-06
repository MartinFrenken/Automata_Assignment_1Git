using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automaton
{
    public class Automaton
    {
        public TransitionSet Transitions { get; }
  
        public Automaton(TransitionSet transitionCollection)
        {
            Transitions = transitionCollection;
        }

     
        
    }
}
