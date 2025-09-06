using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_management_system
{
    class MultipleAnswerQuestion : Question
    {
        public List<string> choices;
        public int[] correctAnswers;
        public MultipleAnswerQuestion(level level, string header, int mark, List<string> choices, int[] correctAnswers) : base(level, header, mark)
        {
            this.choices = choices;
            this.correctAnswers = correctAnswers;
        }
        public override void displayQuestion()
        {
            Console.WriteLine(Header + "\n" + choices[0] + "\n" + choices[1] + "\n"
                + choices[2] + "\n" +
                choices[3] + "\n");
        }
        public override int checkAnswer(List<string> answer)
        {

            if (answer.Count != correctAnswers.Length)

                return 0; // Correct answer

            for (int i = 0; i < answer.Count; i++)
            {
                if (!answer.Contains(correctAnswers[i].ToString()))
                    return 0;
            }
            return this.Mark; // correct answer
        }
    }
}
