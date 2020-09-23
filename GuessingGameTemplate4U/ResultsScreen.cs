using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultsScreen : UserControl
    {
        public ResultsScreen()
        {
            InitializeComponent();
        }

        private void ResultsScreen_Load(object sender, EventArgs e)
        {
            guessesLabel.Text = "Guesses: " + Convert.ToString(Form1.userGuesses.Count());
            
            orderLabel.Text = "Original Order: \n";          
            for (int i = 0; i < Form1.userGuesses.Count(); i++)
            {
                orderLabel.Text += Form1.userGuesses[i] + " ";
            }

            Form1.userGuesses.Sort();
            sortedLabel.Text = "Sorted Order: \n";
            for (int i = 0; i < Form1.userGuesses.Count(); i++)
            {
                sortedLabel.Text += Form1.userGuesses[i] + " ";
            }
        }
    }
}
