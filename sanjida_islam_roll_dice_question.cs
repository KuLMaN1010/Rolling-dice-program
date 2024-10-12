using System;
using Microsoft.Maui.Controls;

namespace Exam_question
{
    public partial class MainPage : ContentPage
    {
        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollDiceClicked(object sender, EventArgs e)
        {
            int roll = random.Next(1, 7);
            DiceLabel.Text = GenerateDiceText(roll);
        }

        private string GenerateDiceText(int roll)
        {
            switch (roll)
            {
                case 1:
                    return "*";
                case 2:
                    return "* *";
                case 3:
                    return " *\n  *\n   *";
                case 4:
                    return "* \n *";
                case 5:
                    return "* *\n  *\n * *";
                case 6:
                    return "* * \n * *\n * *";
                default:
                    return "";
            }
        }
    }
}