using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsQuiz
{
    public partial class Form1 : Form
    {



        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestions(questionNumber);

            totalQuestions = 5;


        }



        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestions(questionNumber);

            }

            questionNumber++;
            askQuestions(questionNumber);

        }

        private void askQuestions(int qnum)
        {


            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Q1;

                    labelQuestion.Text = "A clock strikes once at 1 o’clock, twice at 2 o’clock, thrice at 3 o’clock and so on. How many times will it strike in 24 hours?";

                    button5.Text = "78";
                    button6.Text = "135";
                    button7.Text = "156";
                    button8.Text = "196";

                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Q2;

                    labelQuestion.Text = "Which of the following numbers gives 240 when added to its own square?";

                    button5.Text = "15";
                    button6.Text = "16";
                    button7.Text = "18";
                    button8.Text = "20";

                    correctAnswer = 1;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Q3;

                    labelQuestion.Text = "The simplest form of 1.5 : 2.5 is.......";

                    button5.Text = "6 : 10";
                    button6.Text = "15 : 25";
                    button7.Text = "0.75 : 1.25";
                    button8.Text = "3 : 5";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Q4;

                    labelQuestion.Text = "The average of first 50 natural numbers is ………";

                    button5.Text = "25.30";
                    button6.Text = "25.5";
                    button7.Text = "25.00";
                    button8.Text = "12.25";

                    correctAnswer = 2;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Q5;

                    labelQuestion.Text = "The number of 3-digit numbers divisible by 6, is …………";

                    button5.Text = "149";
                    button6.Text = "166";
                    button7.Text = "150";
                    button8.Text = "151";

                    correctAnswer = 3;

                    break;




            }
        }

      
    }
}

