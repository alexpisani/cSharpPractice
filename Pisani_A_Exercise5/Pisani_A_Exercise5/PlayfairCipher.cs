// Alex Pisani CSCI 1630 April 1 2025
// A simple cipher that swaps the row and column in a custom 5x5 alphabet matrix, encryptying or decrypting a given text

namespace Pisani_A_Exercise5
{
    public partial class PlayfairCipher : Form
    {
        private char[,] matrix = new char[5, 5];  // creates a 5x5 matrix for the cipher key
        public PlayfairCipher()
        {
            InitializeComponent();
        }

        // method to enter keyword into matrix
        private void LoadMatrix(string keyword)
        {
            bool[] used = new bool[26];  // tracks which letters are used
            int row = 0, col = 0;
            string alphabet = "abcdefghiklmnopqrstuvwxyz"; // 'j' is taken out from the alphabet

            keyword = keyword.ToLower().Replace('j', 'i'); // 'j' is treated like 'i'
            string key = "";

            // takes duplicate letters out of keyword
            foreach (char c in keyword)
            {
                if (!key.Contains(c.ToString()))
                {
                    key += c;
                }
            }

            // fills keyword into matrix
            foreach (char c in key)
            {
                matrix[row, col] = c;
                used[c - 'a'] = true;
                col++;

                if (col == 5)
                {
                    col = 0;
                    row++;
                }
            }

            // alphabetically sorts the remaining letters into the matrix
            foreach (char c in alphabet)
            {
                if (!used[c - 'a'])
                {
                    matrix[row, col] = c;
                    used[c - 'a'] = true;
                    col++;

                    if (col == 5)
                    {
                        col = 0;
                        row++;
                    }
                }
            }
        }

        // finds the position of a letter in the matrix
        private (int, int) FindPosition(char letter)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (matrix[row, col] == letter)
                        return (row, col);
                }
            }
            return (-1, -1);  // respond to invalid input
        }

        // method to translate a letter (for both encryption and decryption)
        private char TranslateLetter(char letter)
        {
            (int row, int col) = FindPosition(letter);
            return matrix[col, row];  // swap row and column for encryption/decryption
        }

        // method to process the input text and translate it
        private string ProcessMessage(string input)
        {
            input = input.ToLower().Replace('j', 'i');  // Treat 'j' as 'i'
            string processed = "";

            foreach (char c in input)
            {
                if (c >= 'a' && c <= 'z')  // only process letters
                {
                    processed += TranslateLetter(c);
                }
                else
                {
                    processed += c;  // leave non-alphabet characters unchanged
                }
            }

            return processed.ToUpper();  // return translated text in uppercase
        }

        // translate button handler
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            string phrase = txtText.Text;

            if (string.IsNullOrEmpty(keyword) || string.IsNullOrEmpty(phrase))
            {
                MessageBox.Show("Please provide both the secret word and a text.");
                return;
            }

            LoadMatrix(keyword);  // load the matrix with the keyword
            string result = ProcessMessage(phrase);  // process the input text
            txtResult.Text = result;  // display the translated text in the result textbox
        }

        // clear button handler
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            txtText.Clear();
            txtResult.Clear();
        }

        // exit button handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

