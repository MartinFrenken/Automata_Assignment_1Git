using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Assignment_1.Automatons
{
    public class Automaton
    {
        public  StateSet AutomatonStates { get; }
        public Alphabet Alphabet { get; }
        public Automaton(StateSet states,Alphabet alphabet)
        {
            AutomatonStates=states;
            Alphabet = alphabet;

        }
        public State getFinalState()
        {
            State finalState = AutomatonStates.StoredStates.Find(x => x.IsEndState == true);
            return finalState;
        }
        public bool isDeterministic()
        {
            Analyzer analyzer = new Analyzer();
            return analyzer.isDfa(this);
        }

     
        
    }
}
