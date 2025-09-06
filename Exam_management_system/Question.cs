using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_management_system
{
    class Question
    {
        public Question(level level, string header, int mark)
        {
            Level = level;
            Header = header;
            Mark = mark;
        }



        public level Level { get; set; }
        public string Header { get; set; }
        public int Mark { get; set; }


        public virtual void displayQuestion() { }
        public virtual int checkAnswer(string answer) { return 0; }
        public virtual int checkAnswer(bool answer) { return 0; }
        public virtual int checkAnswer(List<string> answer) { return 0; }


    }
}
