using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleProject
{
    public partial class MainPage : Form
    {
        public static int Game { get; set; }
        public static string VsWord { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        private void SinglePButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            Game = 1;
        }

        private void VSButton_Click(object sender, EventArgs e)
        {
            // Make the VS options visible
            CustomLabel.Visible = true;
            CustomBox.Visible = true;
            VsStart.Visible = true;
        }

        private void VsStart_Click(object sender, EventArgs e)
        {
            string input = CustomBox.Text;
           
            // Check if only letters are entered
            if (System.Text.RegularExpressions.Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                // Check if the length is exactly 5
                if (input.Length == 5)
                {
                    VsWord = input.ToUpper();
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    Game = 2;
                }
                else
                {
                    MessageBox.Show("Error: You must enter exactly 5 letters.");
                }
            }
            else
            {
                MessageBox.Show("Error: Only letters are allowed.");
            }
        }
    }
}
