using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_management_system
{
    class OneChoiceQuestion : Question
    {
        private List<string> choices;
        private int correctAnswerIndex;
        public OneChoiceQuestion(level level, string header, int mark, List<string> choices, int correctAnswerIndex) : base(level, header, mark)
        {
            this.choices = choices;
            this.correctAnswerIndex = correctAnswerIndex;
        }
        public override void displayQuestion()
        {
            Console.WriteLine(Header + "\n" + choices[0] + "\n" + choices[1] + "\n"
                + choices[2] + "\n" +
                choices[3] + "\n");
        }
        public override int checkAnswer(string answer)
        {
            if (choices[correctAnswerIndex] == (answer))

                return this.Mark; // Correct answer


            return 0; // Incorrect answer
        }
    }
}
