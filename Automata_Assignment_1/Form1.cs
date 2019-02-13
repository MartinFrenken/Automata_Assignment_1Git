using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            var x = fi.generateAutomaton();
            MessageBox.Show(analyzer.isDfa(x).ToString());
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
