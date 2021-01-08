using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryPicker
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>(new int [6]);
        int temp = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();

            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i] = randNum.Next(1, 101); 
                outputLabel.Text += $"{numbers[i]} ";
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }
    }
}
