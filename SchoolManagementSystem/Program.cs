using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

internal partial class Program
{
    private static void Main(string[] args)
    {

        string choice = "";
        School school = new School();
        do
        {

            Console.WriteLine("1. Add Student \r\n2. " +
            "Add Instructor\r\n3. " +
            "Add Course\r\n4. " +
            "Enroll Student in Course\r\n5." +
            " Show All Students\r\n6. " +
            "Show All Courses\r\n7. " +
            "Show All Instructors\r\n8." +
            " Find the student by id or name\r\n9." +
            " Fine the course by id or name\r\n" +
            "10. Exit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("please enter the id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter the s.name");
                    string name = Console.ReadLine();
                    Console.WriteLine("please enter the s.age");
                    int age = Convert.ToInt32(Console.ReadLine());
                    List<Course> courses = new List<Course>();
                    Student newStudent = new Student(id, name, age, courses);
                    Console.WriteLine(school.AddStudent(newStudent));
                    break;


                case "2":
                    Console.WriteLine("please enter the i.id");
                    int instructorId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter the i.name");
                    string instructorName = Console.ReadLine();
                    Console.WriteLine("please enter the i.specilization");
                    string specialization = Console.ReadLine();

                    Instructor newInstructor = new Instructor(instructorId, instructorName, specialization);
                    Console.WriteLine(school.AddInstructor(newInstructor));
                    break;

                case "3":
                    Console.WriteLine("please enter the c.id");
                    int courseId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter the c.title");
                    string title = Console.ReadLine();

                    Console.WriteLine("please enter the i.id");
                    int instructorId2 = Convert.ToInt32(Console.ReadLine());
                    if (school.FindInstructor(instructorId2) != null)
                    {
                        Instructor newInstructor2 = school.FindInstructor(instructorId2);
                        Course newCourse = new Course(courseId, title, newInstructor2);
                        Console.WriteLine(school.AddCourse(newCourse));
                    }

                    else Console.WriteLine("Instructor not found, please try again with a valid instructor ID.");
                    break;

                case "4":
                    Console.WriteLine("please enter the s.id");
                    int studentId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter the c.id");
                    int courseId2 = Convert.ToInt32(Console.ReadLine());
                    if (school.EnrollStudentInCourse(studentId, courseId2))
                        Console.WriteLine(school.EnrollStudentInCourse(studentId, courseId2));
                    else Console.WriteLine("process has failed !");

                    break;

                case "5":
                    for (int i = 0; i < school.Students.Count; i++)
                    {
                        Console.WriteLine(school.Students[i].printDetails());
                    }
                    break;

                case "6":
                    for (int i = 0; i < school.Courses.Count; i++)
                    {
                        Console.WriteLine(school.Courses[i].printDetails());
                    }
                    break;

                case "7":

                    for (int i = 0; i < school.Instructors.Count; i++)
                    {
                        Console.WriteLine(school.Instructors[i].printDetails());
                    }

                    break;

                case "8":
                    Console.WriteLine("1. Find by ID\r\n2. Find by Name");
                    if (Console.ReadLine() == "1")
                    {
                        Console.WriteLine("please enter the s.id");
                        int studentIdById = Convert.ToInt32(Console.ReadLine());
                        Student foundStudent = school.FindStudentById(studentIdById);
                        if (foundStudent != null)
                            Console.WriteLine(foundStudent.printDetails());
                        else
                            Console.WriteLine("Student not found.");
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        Console.WriteLine("please enter the s.name");
                        string studentName = Console.ReadLine();
                        Student foundStudentByName = school.FindStudentByNane(studentName);
                        if (foundStudentByName != null)
                            Console.WriteLine(foundStudentByName.printDetails());
                        else
                            Console.WriteLine("Student not found.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, please try again.");
                    }


                    break;

                case "9":
                    Console.WriteLine("1. Find by ID\r\n2. Find by Name");
                    if (Console.ReadLine() == "1")
                    {
                        Console.WriteLine("please enter the c.id");
                        int courseIdById = Convert.ToInt32(Console.ReadLine());
                        Course foundCourse = school.FindCourseById(courseIdById);
                        if (foundCourse != null)
                            Console.WriteLine(foundCourse.printDetails());
                        else
                            Console.WriteLine("course not found.");
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        Console.WriteLine("please enter the c.name");
                        string courseTitle = Console.ReadLine();
                        Course foundCourseByName = school.FindCourseByName(courseTitle);
                        if (foundCourseByName != null)
                            Console.WriteLine(foundCourseByName.printDetails());
                        else
                            Console.WriteLine("course not found.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, please try again.");
                    }
                    break;

                case "10":
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;


            }
        } while (choice != "10");

        Console.WriteLine("Exiting the program. Goodbye!");


    }



}


class Student
{
    public Student(int studentId, string name, int age, List<Course> courses)
    {
        StudentId = studentId;
        Name = name;
        Age = age;
        Courses = courses;
    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<Course> Courses { get; set; }


    public bool enroll(Course course)
    {


        for (int i = 0; i < Courses.Count; i++)
        {

            if (Courses[i].Title == course.Title)
                return true;


        }

        return false;

    }


    public string printDetails()
    {

        if (Courses == null || Courses.Count == 0)
        {
            return "studentId: " + StudentId + ", Name: " + Name + ", Age: " + Age + ", Courses: No courses enrolled";
        }
        string courseDetails = "";
        for (int i = 0; i < Courses.Count; i++)
        {
            courseDetails += Courses[i].printDetails();
        }

        return "studentId: " + StudentId + ", Name: " + Name + ", Age: " + Age + ", Courses: " + courseDetails;



    }

}

class Course
{
    public Course(int courseId, string title, Instructor instructor)
    {
        CourseId = courseId;
        Title = title;
        Instructor = instructor;
    }

    public int CourseId { get; set; }
    public string Title { get; set; }
    public Instructor Instructor { get; set; }

    public string printDetails()
    {



        return "courseId: " + CourseId + ", Title: " + Title + ", Instructor: " + Instructor.Name;



    }


}

class Instructor
{
    public Instructor(int instructorId, string name, string specialization)
    {
        InstructorId = instructorId;
        Name = name;
        Specialization = specialization;
    }
    public int InstructorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }


    public string printDetails()
    {



        return "Instuctor id= " + InstructorId + "Instructor name = " + Name + "Instractor specialization = " + Specialization;


    }
}

class School
{
    public School()
    {

        Students = new List<Student>();
        Instructors = new List<Instructor>();
        Courses = new List<Course>();
    }

    public List<Student> Students { get; set; }
    public List<Instructor> Instructors { get; set; }
    public List<Course> Courses { get; set; }


    public bool AddStudent(Student student)
    {


        for (int i = 0; i < Students.Count; i++)
        {

            if (student.StudentId == Students[i].StudentId)

                Console.WriteLine("Student with this ID already exists");
            return false; // Student with this ID already exists

        }


        Students.Add(student);
        return true;

    }
    public bool AddCourse(Course course)
    {


        for (int i = 0; i < Courses.Count; i++)
        {

            if (course.CourseId == Courses[i].CourseId)

                Console.WriteLine("Course with this ID already exists");
            return false; // Student with this ID already exists

        }


        Courses.Add(course);
        return true;

    }
    public bool AddInstructor(Instructor instructor)
    {


        for (int i = 0; i < Courses.Count; i++)
        {

            if (instructor.InstructorId == Instructors[i].InstructorId)

                Console.WriteLine("Instructor with this ID already exists");
            return false; // Student with this ID already exists

        }


        Instructors.Add(instructor);
        return true;

    }

    public Student FindStudentById(int studentId)
    {

        for (int i = 0; i < Students.Count; i++)
        {

            if (Students[i].StudentId == studentId)
                return Students[i];


        }
        return null;
    }
    public Student FindStudentByNane(string studentName)
    {

        for (int i = 0; i < Students.Count; i++)
        {

            if (Students[i].Name == studentName)
                return Students[i];


        }
        return null;
    }
    public Course FindCourseById(int courseId)
    {

        for (int i = 0; i < Courses.Count; i++)
        {

            if (Courses[i].CourseId == courseId)
                return Courses[i];


        }
        return null;
    }
    public Course FindCourseByName(string courseTitle)
    {

        for (int i = 0; i < Courses.Count; i++)
        {

            if (Courses[i].Title == courseTitle)
                return Courses[i];


        }
        return null;
    }
    public Instructor FindInstructor(int instructorId)
    {

        for (int i = 0; i < Instructors.Count; i++)
        {

            if (Instructors[i].InstructorId == instructorId)
                return Instructors[i];


        }
        return null;
    }

    public bool findIfStudentEnrollInCourse(int studentId, int courseId)
    {


        for (int i = 0; i < Students.Count; i++)
        {

            if (Students[i].StudentId == studentId && Students[i].Courses.Count != 0 || Students[i].Courses != null)
            {
                for (int j = 0; j < Students[i].Courses.Count; j++)
                {
                    if (Students[i].Courses[j].CourseId == courseId)
                    {
                        Console.WriteLine("Student is already enrolled in this course.");
                        return true;
                    }
                }

                return false; // Student is not enrolled in this course
            }



        }
        return false; // Student not found or has no courses enrolled

    }
    public bool EnrollStudentInCourse(int studentId, int courseId)
    {

        foreach (var item in Courses)
        {
            if (item.CourseId == courseId)
            {
                for (int i = 0; i < Students.Count; i++)
                {

                    if (Students[i].StudentId == studentId)
                    {
                        Students[i].Courses.Add(item);
                        return true;
                    }

                }
                return false; // student dont exist   
            }

        }


        return false; // course not found
    }
}


