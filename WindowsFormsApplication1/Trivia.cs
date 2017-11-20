using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class QuestionAndAnswer
    {
        private string question ="";
        private string correctAnswer ="";
        private string[] answers;

        public QuestionAndAnswer()
        { 
            answers = new string[4];

        }

        public string Question {
            set { question = value; }
            get { return question; }
        } 

        public string CorrectAnswer
        {
            set { correctAnswer = value; }
            get { return correctAnswer; }
        }

        public string Answer1
        {
            set { answers[0] = value; }
            get { return answers[0]; }
        }

        public string Answer2
        {
            set { answers[1] = value; }
            get { return answers[1]; }
        }

        public string Answer3
        {
            set { answers[2] = value; }
            get { return answers[2]; }
        }

        public string Answer4
        {
            set { answers[3] = value; }
            get { return answers[3]; }
        }
        
    }
    class Trivia
    {
        private Trivia _Trivia;
        private int mostQuestionsToAsk;
        private int totalQuestionsAsked;
        private QuestionAndAnswer currentQuestionAndAnswer;
        private int score;
        public List<QuestionAndAnswer> questionAndAnswers;
     

        public Trivia()
        {
            score = 0;
            totalQuestionsAsked = 0;
            mostQuestionsToAsk = 3;
            questionAndAnswers = new List<QuestionAndAnswer>();
  
        }

        public Trivia(int i)
        {
            score = 0;
            totalQuestionsAsked = 0;
            mostQuestionsToAsk = i;
            questionAndAnswers = new List<QuestionAndAnswer>();

        }
        //load answers
        public void loadAnswerAndQuestions()
        {
            foreach (string file in Directory.EnumerateFiles(@"Questions", "*.txt"))
            {
                QuestionAndAnswer qa = new QuestionAndAnswer();

                int i = 0;
                foreach (string line in File.ReadLines(file))
                {
                    switch (i)
                    {
                        case 0:
                            qa.Question = line;
                            break;
                        case 1:
                            qa.CorrectAnswer = line;
                            break;
                        case 2:
                            qa.Answer1 = line;
                            break;
                        case 3:
                            qa.Answer2 = line;
                            break;
                        case 4:
                            qa.Answer3 = line;
                            break;
                        case 5:
                            qa.Answer4 = line;
                            break;
                    }
                    i++;

                }
                questionAndAnswers.Add(qa);

            }

        }

        public String answer1()
        {
            return currentQuestionAndAnswer.Answer1;
        }
        public String answer2()
        {
            return currentQuestionAndAnswer.Answer2;

        }
        public String answer3()
        {
            return currentQuestionAndAnswer.Answer3;

        }
        public String answer4()
        {
            return currentQuestionAndAnswer.Answer4;

        }



        public String RandomQuestion()
        {
            if (totalQuestionsAsked < mostQuestionsToAsk)
            {
                Random rnd = new Random();
                int questionNumber = rnd.Next(0, questionAndAnswers.Count);
                currentQuestionAndAnswer = questionAndAnswers.ElementAt(questionNumber);
                questionAndAnswers.RemoveAt(questionNumber);
                totalQuestionsAsked++;
                return currentQuestionAndAnswer.Question;
            }
            else
            {
                return null;
            }

        }
        //checks if player gets question right
        public Boolean rightOrWrong(String answer)
        {
            
            if (answer.Equals(currentQuestionAndAnswer.CorrectAnswer))
            {
                score += 10;
                return true;

            }
            else

            {
            
                return false;
            }
        }

        public int getScore()
        {
            return score;
        }

        public int QuestionAsked()
        {
            return totalQuestionsAsked;
        }
    }
}    
