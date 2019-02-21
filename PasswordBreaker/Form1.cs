using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordBreaker
{
    public partial class Form1 : Form
    {
        string guess = "";
        string password = "tracy";

        public Form1()
        {           
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            guess = txtInput.Text.ToLower();
            correctLength(guess, password);
            correctLetters(guess, password);
            lblCorrect.Visible = true;
            lblLength.Visible = true;
            lblPlace.Visible = true;
        }

        public void correctLength(string guess, string pass)
        {
            int numLetters = pass.Length;
            if (guess.Length > pass.Length)
                lblLength.Text = "Your Guess is too long";
            else if (guess.Length < pass.Length)
                lblLength.Text = "Your Guess is too short";
            else if (guess.Length == pass.Length)
                lblLength.Text = "Your Guess is the correct length!";
        }

        public void correctLetters(string guess, string pass)
        {
            int correct=0;
            char[] correctChar = pass.ToCharArray();
            char[] guessChar = guess.ToCharArray();

            for(int i = 0; i < guessChar.Length; i++){
                if (correctChar.Contains(guessChar[i]))
                    correct++;
            }

            lblCorrect.Text = "You have " + correct + " letters in your guess";

        }

        public void correctPlace(string guess, string pass)
        {

        }

    }
}
