using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;



namespace WordleProject
{
    public partial class Form1 : Form
    {
        string hiddenWord;
        int row = 1;
        bool check = false;
        bool FirstCheck = true;
        bool apiComplete = false;
        string enteredWord = "";
        bool startGame = true;
        public Form1()
        {
            InitializeComponent();

        }

        public void WordGenerator()
        {
            MainPage mainPage = new MainPage(); //Get Values from the other form
            int GameValue = MainPage.Game;
            string VsWord = MainPage.VsWord;
            if (GameValue == 1)
            {
                string[] wordBank = { "APPLE", "FUZZY", "QUICK", "QUACK", "EARTH", "DRIVE", "JOCKY", "FABLE", "EAGLE", "OASIS", "TABLE", "SMILE", "MANGO", "HORSE", "GRAPE" };
                Random random = new Random();
                int randomIndex = random.Next(0, wordBank.Length);
                hiddenWord = wordBank[randomIndex];
            }
            else
            {
                hiddenWord = VsWord;
            }
            startGame = false;
        }

        //private async Task<bool> IsRealWord(string enteredWord) //not working
        //{
        //  for (int r = 1; r <= row; r++)
        //{

        //    TextBox[] textBoxes = new TextBox[]
        //    {
        //Controls.Find($"Row{r}B1", true).FirstOrDefault() as TextBox,
        //Controls.Find($"Row{r}B2", true).FirstOrDefault() as TextBox,
        //Controls.Find($"Row{r}B3", true).FirstOrDefault() as TextBox,
        //Controls.Find($"Row{r}B4", true).FirstOrDefault() as TextBox,
        //Controls.Find($"Row{r}B5", true).FirstOrDefault() as TextBox
        //    };

        //    for (int c = 0; c < textBoxes.Length; c++)
        //    {
        //        enteredWord += textBoxes[c].Text.ToUpper();
        //    }
        //}

        //string apiKey = "757dbfe0-7425-46c3-8d67-7a727fe47d12";
        //string apiUrl = $"https://www.dictionaryapi.com/api/v3/references/collegiate/json/{enteredWord}?key={apiKey}";
        //using (HttpClient client = new HttpClient())
        //{


        //        string response= await Task.Run(()=>client.GetStringAsync(apiUrl));

        //        // If the response is an array, the word is valid
        //        if(response.ToUpper().Contains($"{enteredWord}")) //Anuraj from dotnettthoughts.net and People from GitHub suggested which free dictionary api to use and gave me a good base to start with 
        //        {
        //            check = true;

        //            return true;
        //        }
        //        else
        //        {
        //            check = false;
        //            return false;
        //        }




        //}
        //}
        //private async void WordValidator() //Not working
        //{


        //    for (int r = 1; r <= row; r++)
        //    {
        //        enteredWord = "";
        //        TextBox[] textBoxes = new TextBox[]
        //        {
        //    Controls.Find($"Row{r}B1", true).FirstOrDefault() as TextBox,
        //    Controls.Find($"Row{r}B2", true).FirstOrDefault() as TextBox,
        //    Controls.Find($"Row{r}B3", true).FirstOrDefault() as TextBox,
        //    Controls.Find($"Row{r}B4", true).FirstOrDefault() as TextBox,
        //    Controls.Find($"Row{r}B5", true).FirstOrDefault() as TextBox
        //        };

        //        for (int c = 0; c < textBoxes.Length; c++)
        //        {
        //            enteredWord += textBoxes[c].Text.ToUpper();
        //        }
        //    }

            // Check if the entered word is a real word
            //bool isRealWord=false;
            //var task = IsRealWord(enteredWord);
            //task.Wait();
            //isRealWord = task.Result;
            //isRealWord = await Task.Run(()=>IsRealWord(enteredWord));
            // Task.Run(async () =>
            //{
            //    isRealWord = IsRealWord(enteredWord);
            //});
            //        if (isRealWord == false)
            //        {
            //            this.Invoke((Action)(() =>
            //            {
            //                check = false;
            //                MessageBox.Show("The entered word is not valid.", "Word Check");
            //                bool test = false;
            //                Checker(test);
            //                return;
            //            }));
            //            // Handle the situation when the entered word is not valid

            //        }
            //        else
            //        {
            //            check = true;
            //            bool test = true;
            //            Checker(test);
            //            MessageBox.Show("The entered word is valid.", "Word Check");
            //            return;
            //        }

            //    ;
            //}
            //private async void WordValidator() //Not working
            //{
            //    string enteredWord = "";

            //    for (int r = 1; r <= row; r++)
            //    {
            //        enteredWord = "";
            //        TextBox[] textBoxes = new TextBox[]
            //        {
            //    Controls.Find($"Row{r}B1", true).FirstOrDefault() as TextBox,
            //    Controls.Find($"Row{r}B2", true).FirstOrDefault() as TextBox,
            //    Controls.Find($"Row{r}B3", true).FirstOrDefault() as TextBox,
            //    Controls.Find($"Row{r}B4", true).FirstOrDefault() as TextBox,
            //    Controls.Find($"Row{r}B5", true).FirstOrDefault() as TextBox
            //        };

            //        for (int c = 0; c < textBoxes.Length; c++)
            //        {
            //            enteredWord += textBoxes[c].Text.ToUpper();
            //        }
            //    }

            //    // Check if the entered word is a real word
            //    await Task.Run(async () =>
            //    {
            //        bool isRealWord = await IsRealWord(enteredWord);

            //        if (isRealWord == false)
            //        {
            //            this.Invoke((Action)(() =>
            //            {
            //                check = false;
            //                MessageBox.Show("The entered word is not valid.", "Word Check");
            //                enteredWord = "";
            //                bool test = false;
            //                Checker(test);
            //                return;
            //            }));
            //            // Handle the situation when the entered word is not valid

            //        }
            //        else
            //        {
            //            check = true;
            //            bool test = true;
            //            Checker(test);
            //            MessageBox.Show("The entered word is valid.", "Word Check");
            //            return;
            //        }

            //    });
            //}
            //public bool Checker(bool test)
            //{


            //    if(test==true)
            //    {
            //        check = true;
            //        return true;
            //    }
            //    else
            //    {
            //        check = false;
            //        return false;
            //    }


            //}
            public void WordProcessing()
            {
                char[] characters = { hiddenWord[0], hiddenWord[1], hiddenWord[2], hiddenWord[3], hiddenWord[4] };


                for (int r = 1; r <= row; r++)
                {
                    TextBox[] textBoxes = new TextBox[]
                    {
            Controls.Find($"Row{r}B1", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B2", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B3", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B4", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B5", true).FirstOrDefault() as TextBox
                    };

                    for (int c = 0; c < textBoxes.Length; c++)
                    {
                        char guess = textBoxes[c].Text.ToUpper().FirstOrDefault(); //Set all entered letters to capital

                        if (characters[c] == guess)
                            textBoxes[c].BackColor = Color.Green;
                        else if (hiddenWord.Contains(guess))
                            textBoxes[c].BackColor = Color.Yellow;
                        else
                            textBoxes[c].BackColor = Color.Red;
                    }
                }
            }


            private void NewWordChecker()
            {
                FirstCheck = true;

                for (int r = 1; r <= row; r++)
                {
                    for (int c = 1; c <= 5; c++)
                    {
                        TextBox textBox = Controls.Find($"Row{r}B{c}", true).FirstOrDefault() as TextBox;

                        if (textBox != null)
                        {
                            if (textBox.Text.Length != 1 || !char.IsLetter(textBox.Text[0])) //Check that letters are entered
                            {
                                MessageBox.Show($"Error in Row {r}, Box {c}: Enter one letter in each text box");
                                FirstCheck = false;
                                return;
                            }

                        }
                    }
                }
            }
            private void WinCheck()
            {


                for (int r = 1; r <= row; r++)
                {
                    enteredWord = "";

                    TextBox[] textBoxes = new TextBox[]
                    {
            Controls.Find($"Row{r}B1", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B2", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B3", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B4", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B5", true).FirstOrDefault() as TextBox
                    };

                    for (int c = 0; c < textBoxes.Length; c++)
                    {

                        char guess = textBoxes[c].Text.ToUpper().FirstOrDefault();

                        enteredWord += guess; // Concatenate the guessed character to the enteredWord

                    }
                }

                if (enteredWord == hiddenWord)
                {
                    MessageBox.Show($"Congratulations! You've guessed the word correctly! It was {hiddenWord}");
                    End();
                }

                if (row == 6 && enteredWord != hiddenWord)
                {
                    MessageBox.Show($"Game over. You didn't guess the word correctly, It was {hiddenWord}");
                    End();
                }

            }

            private void Enable()
            {

                if (row == 1)
                {
                    Row2B1.Enabled = true;
                    Row2B2.Enabled = true;
                    Row2B3.Enabled = true;
                    Row2B4.Enabled = true;
                    Row2B5.Enabled = true;

                    Row1B1.Enabled = false;
                    Row1B2.Enabled = false;
                    Row1B3.Enabled = false;
                    Row1B4.Enabled = false;
                    Row1B5.Enabled = false;
                }


                if (row == 2)
                {
                    Row3B1.Enabled = true;
                    Row3B2.Enabled = true;
                    Row3B3.Enabled = true;
                    Row3B4.Enabled = true;
                    Row3B5.Enabled = true;

                    Row2B1.Enabled = false;
                    Row2B2.Enabled = false;
                    Row2B3.Enabled = false;
                    Row2B4.Enabled = false;
                    Row2B5.Enabled = false;
                }


                if (row == 3)
                {
                    Row4B1.Enabled = true;
                    Row4B2.Enabled = true;
                    Row4B3.Enabled = true;
                    Row4B4.Enabled = true;
                    Row4B5.Enabled = true;


                    Row3B1.Enabled = false;
                    Row3B2.Enabled = false;
                    Row3B3.Enabled = false;
                    Row3B4.Enabled = false;
                    Row3B5.Enabled = false;
                }
                if (row == 4)
                {
                    Row5B1.Enabled = true;
                    Row5B2.Enabled = true;
                    Row5B3.Enabled = true;
                    Row5B4.Enabled = true;
                    Row5B5.Enabled = true;

                    Row4B1.Enabled = false;
                    Row4B2.Enabled = false;
                    Row4B3.Enabled = false;
                    Row4B4.Enabled = false;
                    Row4B5.Enabled = false;

                }
                if (row == 5)
                {
                    Row6B1.Enabled = true;
                    Row6B2.Enabled = true;
                    Row6B3.Enabled = true;
                    Row6B4.Enabled = true;
                    Row6B5.Enabled = true;

                    Row5B1.Enabled = false;
                    Row5B2.Enabled = false;
                    Row5B3.Enabled = false;
                    Row5B4.Enabled = false;
                    Row5B5.Enabled = false;
                }
                if (row == 6)
                {
                    Row6B1.Enabled = false;
                    Row6B2.Enabled = false;
                    Row6B3.Enabled = false;
                    Row6B4.Enabled = false;
                    Row6B5.Enabled = false;
                }
            } //Enable row that is being used


            private void End() //Disable all text boxes and button when Game is over
            {
                foreach (Control control in Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Enabled = false;
                    }
                }
                ConfirmButton.Enabled = false;
            }

            private void ConfirmButton_Click(object sender, EventArgs e)
            {
                if (startGame == true)
                {
                    WordGenerator();

                }


                NewWordChecker();
                if (FirstCheck == true)
                {
                    for (int r = 1; r <= row; r++)
                    {
                        enteredWord = "";
                        TextBox[] textBoxes = new TextBox[]
                        {
            Controls.Find($"Row{r}B1", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B2", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B3", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B4", true).FirstOrDefault() as TextBox,
            Controls.Find($"Row{r}B5", true).FirstOrDefault() as TextBox
                        };

                        for (int c = 0; c < textBoxes.Length; c++)
                        {
                            enteredWord += textBoxes[c].Text.ToUpper();
                        }
                    }
                    //WordValidator();//if word is not real i dont want the rest of the code to happen
                    //Checker(check);

                    if (FirstCheck == true)
                    {

                        Enable();
                        WordProcessing();
                        WinCheck();
                        row++;
                        check = false;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        return;
                    }

                }


            }
            private void ResetButton_Click(object sender, EventArgs e)
            {

                // Reset game values
                row = 0;
                check = true;
                WordGenerator();

                // Enable all text boxes and buttons
                foreach (Control control in Controls)
                {
                    //Clear textboxes and reset background color
                    if (control is TextBox textBox)
                    {
                        textBox.Text = "";
                        textBox.Enabled = true;
                        textBox.BackColor = SystemColors.Window;
                    }
                }

                ConfirmButton.Enabled = true; // Enable ConfirmButton if it  was disabled when the game ended

                // Reset textboxes to only row 1 being enabled
                //For some reason the textboxes look different when this button is pressed but they function the way I want
                for (int i = 2; i <= 6; i++)
                {
                    for (int c = 1; c <= 5; c++)
                    {
                        TextBox textBox = Controls.Find($"Row{i}B{c}", true).FirstOrDefault() as TextBox;
                        if (textBox != null)
                        {
                            textBox.Enabled = false;

                        }
                    }
                }
            }

            private void ReturnButton_Click(object sender, EventArgs e)
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
        
    }
}
