using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automata_Assignment_1.Automatons;

namespace Automata_Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FileInterpreter fi = new FileInterpreter();
            Analyzer analyzer = new Analyzer();
            var generatedAutomaton = fi.generateAutomaton();
            MessageBox.Show(analyzer.isDfa(generatedAutomaton).ToString());
            dotFileWriter dw = new dotFileWriter();
            dw.writeToDotFile(generatedAutomaton);
            generateGraph();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void generateGraph()
        {
           

            Process dot = new Process();

            dot.StartInfo.FileName = "dot.exe";

            dot.StartInfo.Arguments = "-Tpng -o result.png automaton.dot";

            dot.Start();

            dot.WaitForExit();
            pictureBox1.ImageLocation = "result.png";



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
