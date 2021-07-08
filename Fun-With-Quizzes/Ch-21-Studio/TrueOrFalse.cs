using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    class TrueOrFalse : Question
    {
        public bool CorrectAnswer { get; set; }
        public TrueOrFalse(string question, bool answer)
            : base(question)
        {
            CorrectAnswer = answer;
            PromptUserInput();
            ProvideFeedback();
        }
        // "T/F: Rae is pretty.", true
        // "T/F: Prof. Cornelius is a cat.", false

        public override void PromptUserInput()
        {
            Console.WriteLine(QuestionBody);
            UserAnswer = Console.ReadLine();
        }

        public override bool VerifyUserAnswer()
        {
            if (bool.Parse(UserAnswer) == CorrectAnswer)
            {
                AnswerIsCorrect = true;
            }
            else
            {
                AnswerIsCorrect = false;
            }
            return base.AnswerIsCorrect;
        }
    }
}
