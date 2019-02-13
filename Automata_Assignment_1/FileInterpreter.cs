using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Automata_Assignment_1.Automatons;
using System.Text.RegularExpressions;

namespace Automata_Assignment_1
{
    public class FileInterpreter
    {
        static string fileLocation = "D:\\automata.txt";
        LanguageSyntax ls = new LanguageSyntax();
        StreamReader sr = new StreamReader(fileLocation);
        StateSet stateSet = new StateSet();
        Alphabet alphabet = new Alphabet();
        string currentLine;
        

        public FileInterpreter()
        {
            readFile();
        }
        public void readFile()
        {
            currentLine = sr.ReadLine();
            while (currentLine != null)
            { 

                Console.WriteLine(currentLine);
                if (currentLine.StartsWith(ls.Comment))
                {
                    Console.WriteLine("That was a commment!");
                }
                else if (currentLine.StartsWith(ls.Alphabet))
                {
                    generateAlphabet();
                }
                else if (currentLine.StartsWith(ls.StateCollection))
                {
                    generateStateCollection();
                }
                else if (currentLine.StartsWith(ls.FinalStateCollection))
                {
                    addFinalStates();
                }
                else if (currentLine.StartsWith(ls.Transition))
                {
                    addTransitions();
                }

                currentLine = sr.ReadLine();
                 
            }
        }
        public Automaton generateAutomaton()
        {
            
            var generatedAutomaton= new Automaton(stateSet, alphabet);

            return generatedAutomaton;
        }
        void generateAlphabet()
        {
         
            string trimmedLine = trimCurrentLine(ls.Alphabet);
         
            foreach (char c in trimmedLine)
            {
                alphabet.Add(c);
            }
        }

        void generateStateCollection()
        {
           
            string trimmedLine = trimCurrentLine(ls.StateCollection);
            List<string> states = seperateString(trimmedLine);
            State newState;
            for (int i=0;i<states.Count;i++)
            {
                if (i == 0)
                {
                newState = new State(states.ElementAt(i),true);
                }
                else
                {
                newState = new State(states.ElementAt(i));
                }
                stateSet.add(newState);
            }

            
        }

        void addFinalStates()
        {
            string trimmedLine = trimCurrentLine(ls.FinalStateCollection);
            List<string> finalStates = seperateString(trimmedLine);
            StateSet finalStateSet = new StateSet();
            foreach (string stateName in finalStates)
            {
                State newState = new State(stateName);
                finalStateSet.add(newState);
            }

            foreach (State state in stateSet.StoredStates)
            {
                foreach (State finalState in finalStateSet.StoredStates)
                {
                    if (state.StateName == finalState.StateName)
                    {
                        state.SetEndState();
                    }
                }
                
            }
        }

        void addTransitions()
        {
            currentLine = sr.ReadLine();
            List<string>transitionStrings=new List<string>();
            while (currentLine != ls.Endline)
            {
                if (currentLine != null)
                { 
                transitionStrings.Add(currentLine);
                }
                currentLine = sr.ReadLine();
            }

            foreach (string transition in transitionStrings)
            {

                string trimmedTransition = clearSpaces(transition);
                string[] splitTransition = Regex.Split(trimmedTransition, "-->|,|//s");

                //The first string in the splitTransition is the initial state, the second is the transition character and the third is the destination state

                State initialState = stateSet.StoredStates.Find(state => state.StateName == splitTransition[0]);
                State finalState = new State(splitTransition[2]);
                Transition transitionToAdd = new Transition(splitTransition[1][0], finalState);
                initialState.AddTransition(transitionToAdd);
               
          
            }


        }

        string trimCurrentLine(string wordToRemove)
        {
            string trimmedOne = currentLine.Replace(wordToRemove, "");
            string trimmedTwo = trimmedOne.Trim(' ');
            return trimmedTwo;
        }
        string clearSpaces(string inputString)
        {
            string trimmedOne = inputString.Replace(" ","");
            return trimmedOne;
        }

        List<string> seperateString(string lineToSeparate)
        {
            return lineToSeparate.Split(',').ToList<string>();
            
        }

    }
}
