using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    class MultipleChoice : Question
    {
        public string[] PossibleAnswers { get; set; }
        public string CorrectAnswer { get; set; }

        public MultipleChoice(string question, string[] possibleAnswers, string answer)
            : base(question)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswer = answer;
            PromptUserInput();
            ProvideFeedback();
        }

        public override void PromptUserInput()
        {
            Console.WriteLine(QuestionBody);
            for (int i = 0; i < PossibleAnswers.Length; i++)
            {
                Console.WriteLine(PossibleAnswers[i]);
            }
            UserAnswer = Console.ReadLine();
            VerifyUserAnswer();
        }

        public override bool VerifyUserAnswer()
        {
            if (UserAnswer.Length == 1)
            {
                if (UserAnswer.Equals(CorrectAnswer))
                {
                    AnswerIsCorrect = true;
                }
                else
                {
                    AnswerIsCorrect = false;
                }
            }
            else
            {
                Console.WriteLine("Please enter a, b, c, or d.\n");
                PromptUserInput();
            }

            return AnswerIsCorrect;
        }

        // What is Rae's favorite flavor of ice cream?
        // a. Chocolate - correct answer
        // b. Vanilla
        // c. Strawberry
        // d. Corn and cheese
        // If user picks a), return AnswerCorrect = true;
        // If user picks any other answer, return AnswerCorrect = false;
    }
}
