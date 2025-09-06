using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_management_system
{
    class TrueAndFalseQuestion : Question
    {
        private string[] choices;
        private int correctAnswerIndex;
        public TrueAndFalseQuestion(level level, string header, int mark, string[] choices, int correctAnswerIndex) : base(level, header, mark)
        {
            this.choices = choices;
            this.correctAnswerIndex = correctAnswerIndex;
        }
        public override void displayQuestion()
        {
            Console.WriteLine(Header + "\n" +"0-"+ choices[0] + "\n" +"1-"+ choices[1]);
        }
        public override int checkAnswer(string answer)
        {

            if (choices[correctAnswerIndex].ToString() == answer)
                return this.Mark; // Correct answer
            return 0; // Incorrect answer

        }
    }
}
