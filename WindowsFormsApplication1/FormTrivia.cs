using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormTrivia : Form
    {
        private Trivia _trivia;
        private int amountCorrect;
        private int amountIncorrect;
        private int t;


        public FormTrivia()
        {
            InitializeComponent();

            _trivia = new Trivia();

            _trivia.loadAnswerAndQuestions();

            questionDisplay.Text = _trivia.RandomQuestion();
            Answer1.Text = _trivia.answer1();
            Answer2.Text = _trivia.answer2();
            Answer3.Text = _trivia.answer3();
            Answer4.Text = _trivia.answer4();

            //ScoreDisplay.Text = _trivia.getScore() + "";

            amountCorrect = 0;
            amountIncorrect = 0;

        }

        public FormTrivia(int i, int type)
        {
            InitializeComponent();
            t = type;

            _trivia = new Trivia(i);

            _trivia.loadAnswerAndQuestions();

            questionDisplay.Text = _trivia.RandomQuestion();
            Answer1.Text = _trivia.answer1();
            Answer2.Text = _trivia.answer2();
            Answer3.Text = _trivia.answer3();
            Answer4.Text = _trivia.answer4();

            //ScoreDisplay.Text = _trivia.getScore() + "";

            amountCorrect = 0;
            amountIncorrect = 0;

        }



        public void updatQuestion()
        {
            string question = _trivia.RandomQuestion();

            if (question != null)
            {
                questionDisplay.Text = question;

                Answer1.Text = _trivia.answer1();
                Answer2.Text = _trivia.answer2();
                Answer3.Text = _trivia.answer3();
                Answer4.Text = _trivia.answer4();

                Answer1.BackColor = DefaultBackColor;
                Answer2.BackColor = DefaultBackColor;
                Answer3.BackColor = DefaultBackColor;
                Answer4.BackColor = DefaultBackColor;

                ScoreDisplay.Text = _trivia.getScore() + "";
            }
            else
            {
                string msg = "";
                string anothermsg = "";
                int i = _trivia.QuestionAsked();

                if (amountCorrect == i)
                {
                    msg = "Great job you beat the challenge!";
                }
                else
                {
                    if (t == 1)
                    {
                        msg = "Bats will now carry you now";
                    }
                    if (t == 2)
                    {
                        msg = "Uh oh! Looks like you fell into a bottomless pit.";
                    }
                    if (t == 3)
                    {
                        msg = "The Wumpus has killed you.";
                    }
                    int j = i - amountIncorrect;

                    anothermsg = " You answered " + i + " questions and got " + j + " correct. Better luck next time!";
                }
                DialogResult r = MessageBox.Show(msg + ""+ anothermsg + "\nScore: "+_trivia.getScore());
                this.Close();
                Application.Exit();
            }

        }

        public void displayAmount()
        {
            DialogResult r = MessageBox.Show("Amount Correct: " + amountCorrect + " out of " + (amountCorrect + amountIncorrect));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_trivia.rightOrWrong(Answer2.Text))
            {
                Answer2.BackColor = Color.LightGreen;
                amountCorrect++;
            }
            else
            {                
                Answer2.BackColor = Color.PaleVioletRed;
                amountIncorrect++;
            }
            displayAmount();
            updatQuestion();
        }

        private void FormTrivia_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void qLabel_Click(object sender, EventArgs e)
        {

        }

        private void Answer1_Click(object sender, EventArgs e)
        {
            if (_trivia.rightOrWrong(Answer1.Text))
            {
                Answer1.BackColor = Color.LightGreen;
                amountCorrect++;
            }
            else
            {
                Answer1.BackColor = Color.PaleVioletRed;
                amountIncorrect++;
            }
            displayAmount();
            updatQuestion();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            if (_trivia.rightOrWrong(Answer3.Text))
            {
                Answer3.BackColor = Color.LightGreen;
                amountCorrect++;
            }
            else
            {
                Answer3.BackColor = Color.PaleVioletRed;
                amountIncorrect++;
            }
            displayAmount();
            updatQuestion();
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            if (_trivia.rightOrWrong(Answer4.Text))
            {
                Answer4.BackColor = Color.LightGreen;
                amountCorrect++;
            }
            else
            {
                Answer4.BackColor = Color.PaleVioletRed;
                amountIncorrect++;
            }
            displayAmount();
            updatQuestion();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public int GetScore()
        {
            return _trivia.getScore();
        }
    }
}
