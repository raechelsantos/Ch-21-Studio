﻿using System;

namespace Ch_21_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz testQuiz = new Quiz();

            TrueOrFalse isRaePretty = new TrueOrFalse("True or False: Is Rae pretty?", true);
            TrueOrFalse perpetualLackOfFulfillment = new TrueOrFalse("True or False: If I pass this internship and acquire a job at Microsoft, I will find all of the happiness and self-fulfillment that I seek.", false);
            MultipleChoice iceCream = new MultipleChoice("What is Rae's favorite flavor of ice cream?", new string[] { "a. Chocolate", "b. Vanilla", "c. Strawberry" , "d. Corn and cheese"}, "a");
            
            testQuiz.AddQuestion(isRaePretty);
            testQuiz.AddQuestion(perpetualLackOfFulfillment);
            testQuiz.AddQuestion(iceCream);

            testQuiz.CalculateScore();
        }
    }
}
