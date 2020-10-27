using Calculator.Display;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();

        }

        List<string> expressionString = new List<string>() { };
        public void UpdateDisplay(object sender, EventArgs eventArguments)
        {
            Button buttonClicked = sender as Button;
            expressionString.Add(buttonClicked.Text); //sender.GetType().ToString();
            Expression_textBox.Text = String.Join(" ", expressionString.ToArray());

        }
        public void CalculateResult(object sender, EventArgs eventArguments)
        {

        }
        public void ClearDisplay(object sender, EventArgs eventArguments)
        {

        }
    }
}
