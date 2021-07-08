using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    class Checkbox : Question
    {
        public string[] PossibleAnswers { get; set; }
        public string[] CorrectAnswers { get; set; } // Answer key
        public Checkbox(string question, string[] possibleAnswers, string[] correctAnswers)
            : base(question)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswers = correctAnswers;
            PromptUserInput();
            ProvideFeedback();
        }
        
        public override void PromptUserInput() // Displays question and possible answers to prompt user input.
        {
            Console.WriteLine(QuestionBody);
            for (int i = 0; i < PossibleAnswers.Length; i++)
            {
                Console.WriteLine(PossibleAnswers[i]);
            }
        }
        
        public override bool VerifyUserAnswer()
        {
            for (int i = 0; i < PossibleAnswers.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(PossibleAnswers[i]);
                Console.WriteLine("Please enter X to select answer; otherwise, enter O.");
                UserAnswer = Console.ReadLine();
                if (UserAnswer.Contains(CorrectAnswers[i].ToLower()))
                {
                    AnswerIsCorrect = true;
                }
                else
                {
                    AnswerIsCorrect = false;
                }
            }
            return AnswerIsCorrect;
        }

        public override void ProvideFeedback()
        {
            if (this.VerifyUserAnswer())
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