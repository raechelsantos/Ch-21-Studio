using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    class Checkbox : Question
    {
        public Dictionary<string, string> PossibleAnswers { get; set; }
        public Checkbox(string question)
            : base(question)
        {
            PromptUserInput();
            ProvideFeedback();
        }
    }
}
