using Exam_management_system;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;
enum level
{
    easy,
    medium,
    hard
}

internal partial class Program
{
    static List<Question> questions = new List<Question>();

   
    private static void Main(string[] args)
    {

        string choice = "";
        do
        {

            Console.WriteLine("Please choose an action\n1.Doctor mode\r\n" +
            "2.Student mode\r\n" +
            "3.Exit ");
            choice = Console.ReadLine();
         


                switch (choice)
            {
                case "1":
                          doctorMode();
                    break;


                case "2":
              studentMode();
                    break;

                case "3":

                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;


                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;


            } 
         
        } while (choice != "3");



    }

    public static void studentMode()
    {
        string examlevel;
        int studentMark = 0;
        Console.WriteLine("please choose the type of the exam\n1.Practical\n2.Final");
        int examType = int.Parse(Console.ReadLine());

        switch (examType)
        {
            case 1:
                Console.WriteLine("please choose the level of the exam\n1.Easy\n2.Medium\n3.Hard");
                examlevel = Console.ReadLine();
                switch (examlevel)
                {

                    case "1":
                        if (questions == null)
                        {
                            Console.WriteLine("there is no questions in the exam");
                            break;

                        }



                        for (int i = 0; i < questions.FindAll(q => q.Level == level.easy).Count / 2; i++)
                        {
                            questions.FindAll(q => q.Level == level.easy)[i].displayQuestion();

                            string answer = Console.ReadLine();
                            studentMark += questions[i].checkAnswer(answer);


                        }


                        break;
                    case "2":
                        if (questions == null)
                        {
                            Console.WriteLine("there is no questions in the exam");
                            break;

                        }



                        for (int i = 0; i < questions.FindAll(q => q.Level == level.medium).Count / 2; i++)
                        {
                            questions.FindAll(q => q.Level == level.medium)[i].displayQuestion();
                            if (questions[i] is MultipleAnswerQuestion)
                            {
                                Console.WriteLine("please enter your answers separated by commas from (0-3) (e.g., 1,0):");
                                string input = Console.ReadLine();
                                List<string> answers = new List<string>(input.Split(','));
                                studentMark += ((MultipleAnswerQuestion)questions[i]).checkAnswer(answers);
                            }
                            else
                            {
                                string answer = Console.ReadLine();
                                studentMark += questions[i].checkAnswer(answer);
                            }


                        }



                        break;
                    case "3":
                        if (questions == null)
                        {
                            Console.WriteLine("there is no questions in the exam");
                            break;

                        }



                        for (int i = 0; i < questions.FindAll(q => q.Level == level.hard).Count / 2; i++)
                        {
                            questions.FindAll(q => q.Level == level.hard)[i].displayQuestion();
                            if (questions[i] is MultipleAnswerQuestion)
                            {
                                Console.WriteLine("please enter your answers separated by commas from (0-3) (e.g., 1,0):");
                                string input = Console.ReadLine();
                                List<string> answers = new List<string>(input.Split(','));
                                studentMark += ((MultipleAnswerQuestion)questions[i]).checkAnswer(answers);
                            }
                            else
                            {
                                string answer = Console.ReadLine();
                                studentMark += questions[i].checkAnswer(answer);
                            }


                        }

                        break;
                    default: Console.WriteLine("the type is not valid !"); break;

                }
                Console.WriteLine("your mark is " + studentMark);
                break;
            case 2:

                Console.WriteLine("please choose the level of the exam\n1.Easy\n2.Medium\n3.Hard");
                examlevel = Console.ReadLine();
                switch (examlevel)
                {

                    case "1":
                        if (questions == null)
                        {
                            Console.WriteLine("there is no questions in the exam");
                            break;

                        }



                        for (int i = 0; i < questions.FindAll(q => q.Level == level.easy).Count; i++)
                        {
                            questions.FindAll(q => q.Level == level.easy)[i].displayQuestion();
                            if (questions[i] is MultipleAnswerQuestion)
                            {
                                Console.WriteLine("please enter your answers separated by commas from (0-3) (e.g., 1,0):");
                                string input = Console.ReadLine();
                                List<string> answers = new List<string>(input.Split(','));
                                studentMark += ((MultipleAnswerQuestion)questions[i]).checkAnswer(answers);
                            }
                            else
                            {
                                string answer = Console.ReadLine();
                                studentMark += questions[i].checkAnswer(answer);
                            }



                        }


                        break;
                    case "2":
                        if (questions == null)
                        {
                            Console.WriteLine("there is no questions in the exam");
                            break;

                        }



                        for (int i = 0; i < questions.FindAll(q => q.Level == level.medium).Count; i++)
                        {
                            questions.FindAll(q => q.Level == level.medium)[i].displayQuestion();
                            if(questions[i] is MultipleAnswerQuestion)
                            {
                                Console.WriteLine("please enter your answers separated by commas from (0-3) (e.g., 1,0):");
                                string input = Console.ReadLine();
                                List<string> answers = new List<string>(input.Split(','));
                                studentMark += ((MultipleAnswerQuestion)questions[i]).checkAnswer(answers);
                            }
                            else
                            {
                                string answer = Console.ReadLine();
                                studentMark += questions[i].checkAnswer(answer);
                            }
                           


                        }



                        break;
                    case "3":
                        if (questions == null)
                        {
                            Console.WriteLine("there is no questions in the exam");
                            break;

                        }



                        for (int i = 0; i < questions.FindAll(q => q.Level == level.hard).Count; i++)
                        {
                            questions.FindAll(q => q.Level == level.hard)[i].displayQuestion();
                            if (questions[i] is MultipleAnswerQuestion)
                            {
                                Console.WriteLine("please enter your answers separated by commas from (0-3) (e.g., 1,0):");
                                string input = Console.ReadLine();
                                List<string> answers = new List<string>(input.Split(','));
                                studentMark += ((MultipleAnswerQuestion)questions[i]).checkAnswer(answers);
                            }
                            else
                            {
                                string answer = Console.ReadLine();
                                studentMark += questions[i].checkAnswer(answer);
                            }



                        }

                        break;
                    default: Console.WriteLine("the type is not valid !"); break;

                }
                Console.WriteLine("your mark is " + studentMark); break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;



        }


    }
    static void doctorMode()
    {
        Console.WriteLine("please enter the number of questions you want to add");
        int questionsCount = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < questionsCount; i++)
        {
            
            string levelType;
            level questionLevel;
            bool valiedLevel = false;
            bool valiedtype = false;
            string questionType = "";
            while (valiedtype == false)
            {
                Console.WriteLine("please choose the type of question \n 1.One choice question\n 2.Multiple answer question\n 3.True and false question");
                 questionType = Console.ReadLine();
                if(questionType!= "1" && questionType != "2" && questionType != "3")
                {
                    Console.WriteLine("the type is not valid !");
                    valiedtype = false;
                }
                else
                {
                    valiedtype = true;
                    // proceed with the rest of the code
                }

            }
            while (valiedLevel == false)
            {
                Console.WriteLine("please enter the level of the question \n 1.Easy\n 2.Medium\n 3.Hard");

                levelType = Console.ReadLine();
                switch (levelType)
                {
                    case "1": questionLevel = level.easy; valiedLevel = true; break;
                    case "2": questionLevel = level.medium; valiedLevel = true; break;
                    case "3": questionLevel = level.hard; valiedLevel = true; break;
                    default:
                        Console.WriteLine("the level is not valid !");
                        valiedLevel = false;
                        break;
                }
            }

            Console.WriteLine("please enter the header of the question");
            string header = Console.ReadLine();
            Console.WriteLine("please enter the mark of the question");
            int mark = Convert.ToInt32(Console.ReadLine());


            switch (questionType)
            {
                case "1":
                    List<string> choices = new List<string>();
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine($"please enter choice {j + 1}");
                        choices.Add(Console.ReadLine());
                    }
                    Console.WriteLine("please enter the index of the correct answer (1-4)");
                    int correctAnswerIndex = Convert.ToInt32(Console.ReadLine())-1;
                    questions.Add(new OneChoiceQuestion(questionLevel = level.easy, header, mark, choices, correctAnswerIndex));
                    break;
                case "2":
                    List<string> multiChoices = new List<string>();
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine($"please enter choice {j + 1}");
                        multiChoices.Add(Console.ReadLine());
                    }
                    Console.WriteLine("please enter your  correct answers separated by commas from (0-3) (e.g., 1,0):");
                    string[] indexes = Console.ReadLine().Split(',');
                    int[] correctAnswerIndexes = Array.ConvertAll(indexes, int.Parse);
                  
                    questions.Add(new MultipleAnswerQuestion(questionLevel = level.easy, header, mark, multiChoices, correctAnswerIndexes));
                    break;
                case "3":
                    string[] tfChoices = new string[] { "0", "1" };
                    Console.WriteLine("please enter the index) of the correct answer (0 for True, 1 for False)");
                    correctAnswerIndex = Convert.ToInt32(Console.ReadLine());
                    questions.Add(new TrueAndFalseQuestion(questionLevel = level.easy, header, mark, tfChoices, correctAnswerIndex));
                    break;

                default: Console.WriteLine("the type is not valid !"); break;
            }


        }
    }
}


//class Question
//{
//    public Question(level level, string header, int mark)
//    {
//        Level = level;
//        Header = header;
//        Mark = mark;
//    }

 

//    public level Level { get; set; }
//  public string Header { get; set; }
//  public int Mark { get; set; }


//    public virtual void displayQuestion() { }
//    public virtual int checkAnswer(string answer) { return 0; }
//    public virtual int checkAnswer(bool answer) { return 0; }
//    public virtual int checkAnswer(List<string> answer) { return 0; }


//}
//class OneChoiceQuestion : Question
//{
//    private List<string>choices;
//    private int correctAnswerIndex;
//    public OneChoiceQuestion(level level, string header, int mark, List<string> choices, int correctAnswerIndex):base(level,header,mark)
//    {
//        this.choices = choices;
//        this.correctAnswerIndex = correctAnswerIndex;
//    }
//    public override void displayQuestion()
//    {
//        Console.WriteLine(Header+ "\n" + choices[0]+"\n" + choices[1] + "\n" 
//            + choices[2] + "\n" + 
//            choices[3] + "\n");
//    }
//    public override int checkAnswer(string answer)
//    {
//        if(choices[correctAnswerIndex]==(answer))
        
//                return this.Mark; // Correct answer
            
       
//        return 0; // Incorrect answer
//    }
//    }
//class MultipleAnswerQuestion : Question
//{
//    private List<string>choices;
//    private int []correctAnswerIndex;
//    public MultipleAnswerQuestion(level level, string header, int mark, List<string> choices, int[] correctAnswerIndex):base(level,header,mark)
//    {
//        this.choices = choices;
//        this.correctAnswerIndex = correctAnswerIndex;
//    }
//    public override void displayQuestion()
//    {
//        Console.WriteLine(Header+ "\n" + choices[0]+"\n" + choices[1] + "\n" 
//            + choices[2] + "\n" + 
//            choices[3] + "\n");
//    }
//    public override int checkAnswer(List<string> answer)
//    {

//        if(answer.Count!=correctAnswerIndex.Length)
        
//                return 0; // Correct answer

//        for (int i = 0; i < answer.Count; i++) {
//            if (!answer.Contains(choices[correctAnswerIndex[i]]))
//                return 0;
//        }
//            return 1; // correct answer
//    }
//    }
//class TrueAndFalseQuestion : Question
//{
//    private string[]choices;
//    private int correctAnswerIndex;
//    public TrueAndFalseQuestion(level level, string header, int mark, string[] choices, int correctAnswerIndex):base(level,header,mark)
//    {
//        this.choices = choices;
//        this.correctAnswerIndex = correctAnswerIndex;
//    }
//    public override void displayQuestion()
//    {
//        Console.WriteLine(Header+ "\n" + choices[0]+"\n" + choices[1] );
//    }
//    public override int checkAnswer(string answer)
//    {

//        if (choices[correctAnswerIndex]==answer)
//            return this.Mark; // Correct answer
//        return 0; // Incorrect answer

//    }
//    }