using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CowsAndBullsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] secretNumber = new char[4];
        bool hasSecretNumber = false;
        int attempts = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
            attempts = 1;
            List<char> digits = new List<char>(){ '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Random generator = new Random();
            int index = 0;
            hasSecretNumber = true;
            for (int i = 0; i < 4; i++)
            {
               index = generator.Next(digits.Count);
               secretNumber[i] = digits[index];
               digits.Remove(digits[index]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            string caption = "";
            MessageBoxButtons buttons;
            DialogResult result;
            if (hasSecretNumber == false)
            {
                message = @"Please click on the button ""New game"" for a new game";
                buttons = MessageBoxButtons.OK;
                caption = "Press button";
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
            string guessNumber = textBox1.Text.ToString();
            textBox1.Clear();
            char[] guessNumberDigits = guessNumber.ToCharArray();
            char[] secretNumberCopy = new char[4];
            secretNumber.CopyTo(secretNumberCopy, 0);
            int guessNumberIntFormat;
            char usedSecretNumber = '&';
            char usedGuessNumber = '*';
            int bulls = 0;
            int cows = 0;
            if (!(int.TryParse(guessNumber, out guessNumberIntFormat)))
            {
                textBox1.Clear();
                message = "You have entered some wrong symbols. Please enter again";
                caption = "Incorrect format";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
            if (guessNumber.Length != 4)
            {
                textBox1.Clear();
                message = "Please enter a number with four digits.";
                caption = "Wrong length";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(message, caption, buttons);
                return;
            }

            bool uniqueDigits = true;
            for (int i = 0; i < guessNumber.Length - 1; i++)
            {
                for (int j =  i + 1; j < guessNumber.Length; j++)
                {
                    if (guessNumber[i] == guessNumber[j])
                    {
                        uniqueDigits = false;
                        break;
                    }
                }
                if (uniqueDigits == false)
                {
                    break;
                }
            }

            if (uniqueDigits == false)
            {
                textBox1.Clear();
                message = "Please enter number with unique digits.";
                caption = "Repetitive digits";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(message, caption, buttons);
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                if (guessNumber[i] == secretNumberCopy[i])
                {
                    bulls++;
                    guessNumberDigits[i] = usedGuessNumber;
                    secretNumberCopy[i] = usedSecretNumber;
                }
            }

            if (bulls == 4)
            {
                textBox1.Clear();
                richTextBox1.Clear();
                hasSecretNumber = false;
                string secretNumberStr = new string(secretNumber);
                secretNumber = new char[4];
                richTextBox1.AppendText("Congratulations!");
                richTextBox1.AppendText(System.Environment.NewLine);
                richTextBox1.AppendText(System.Environment.NewLine);
                richTextBox1.AppendText( 
                    "You win! Secret number is : " + secretNumberStr);
                richTextBox1.AppendText(System.Environment.NewLine);
                richTextBox1.AppendText(System.Environment.NewLine);
                richTextBox1.AppendText("Number of attempts: " + attempts);
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (guessNumberDigits[j] == secretNumberCopy[i])
                        {
                            cows++;
                            guessNumberDigits[j] = usedGuessNumber;
                            secretNumberCopy[i] = usedSecretNumber;
                        }
                    }
                }
                string currentResult = attempts + ". " + guessNumber + " - " + bulls + " bulls, " 
                                       + cows + " cows" + System.Environment.NewLine;
                richTextBox1.Select(0, 0);
                richTextBox1.SelectedText = currentResult;
                attempts++;
            }
        }
    }
}
