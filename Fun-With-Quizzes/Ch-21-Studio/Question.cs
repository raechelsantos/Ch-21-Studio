using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    public abstract class Question
    {
        public int QuestionNumber { get; set; }
        public string QuestionBody { get; set; }
        public string UserAnswer { get; set; }
        public bool AnswerIsCorrect { get; set; }


        public Question(string question)
        {
            QuestionBody = question;
        }

        public virtual void PromptUserInput() // Prompts user input and verifies user answer against actual answer.
        {
            UserAnswer = Console.ReadLine();
            VerifyUserAnswer();
            ProvideFeedback(); // MULTIPLE CHOICE IS FAILING WHY
        }

        public virtual bool VerifyUserAnswer() // Returns a boolean determining whether or not the user's answer is correct or incorrect.
        {
            if (AnswerIsCorrect)
            {
                AnswerIsCorrect = true;
            }
            else
            {
                AnswerIsCorrect = false;
            }
            return AnswerIsCorrect;
        }

        public virtual void ProvideFeedback() // Writes whether the user's answer is correct or incorrect.
        {
            if (VerifyUserAnswer())
            {
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine("Incorrect.\n");
            }
        }
    }
}
