using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automata_Assignment_1.Automatons;

namespace Automata_Assignment_1
{
    public class dotFileWriter
    {
        public void writeToDotFile(Automaton automaton )
        {
            string doubleCircle = "[shape=doublecircle]";
            string singleCircle = "[shape=circle ]";
            string quote = "\"";
            using (StreamWriter outputFile = new StreamWriter("automaton.txt"))
            {
                outputFile.WriteLine("digraph myAutomaton {");
                outputFile.WriteLine("rankdir=LR;");
                outputFile.WriteLine(quote+quote+"[shape=none]");
                foreach (State state in automaton.AutomatonStates.StoredStates)
                {
                    if (state.IsEndState)
                    {
                        outputFile.WriteLine(quote+state.StateName+quote+" "+doubleCircle);
                    }
                    else
                    {
                        outputFile.WriteLine(state.StateName+" "+ singleCircle);
                    }
                    outputFile.WriteLine("");
                 
                }

                foreach (State state in automaton.AutomatonStates.StoredStates)
                {
                    if (state.IsBeginState)
                    {
                        outputFile.WriteLine(quote + quote + "->" + quote + state.StateName + quote);
                    }
                    foreach (Transition transition in state.Neighbours)
                    {
            
                            outputFile.WriteLine(quote + state.StateName + quote + "->" + quote +
                                                 transition.DestinationState.StateName + quote +
                                                 toLabel(transition.InputCharacter.ToString()));  
                    }
                }

                outputFile.WriteLine("}");

            }

            string toLabel(string inputString)
            {
                return "[label=" + quote + inputString + quote + "]";
            }
           // string strCmdText ="dot -T png -o output.png "
         //   System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
