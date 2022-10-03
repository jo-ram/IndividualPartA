using IndividualPartA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Course> courses = new List<Course>();
        static List<Trainer> trainers = new List<Trainer>();
        static List<Assignment> assignments = new List<Assignment>();

        public static int FindCourse(string title)
        {
            for(int i =0; i<courses.Count; i++)
            {
                if (courses[i].GetTitle() == title)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FindStudent(string firstname, string lastname)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].GetFirstName() == firstname && students[i].GetLastName() == lastname)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FindTrainer(string firstname, string lastname)
        {
            for (int i = 0; i < trainers.Count; i++)
            {
                if (trainers[i].GetFirstName() == firstname && trainers[i].GetLastName() == lastname)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FindAssignment(string title)
        {
            for (int i = 0; i < assignments.Count; i++)
            {
                if (assignments[i].GetTitle() == title )
                {
                    return i;
                }
            }
            return -1;
        }



        static void Main(string[] args)
        {
            
            string input = "-1";

            while(input != "0")
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Welcome to our Private School:\n Choose one of the following by typing the number\n" +
                  "   1.List of all students\n   " +
                  "2.List of all trainers\n   " +
                  "3.List of all assignments\n   " +
                  "4.List of all courses\n" +
                   "   5.Add Student\n   " +
                   "6.Add Course\n   " +
                   "7.Add assignments\n   " +
                   "8.Add trainer\n   " +
                   "9.Assign student to course\n   " +
                   "10.Assign trainer to courser\n   " +
                   "11.Assign assignment to courser\n   " +
                   "12.List of students per course\n   " +
                   "13.List of trainers per course\n   " +
                   "0.Exit");
                Console.WriteLine("--------------------------------------------");
                input = Console.ReadLine();

                if(input == "1")
                {
                    foreach(Student student in students)
                    {
                       student.ToString();
                    }
                }

                if(input == "2")
                {
                    foreach(Trainer trainer in trainers)
                    {
                        trainer.ToString();
                    }
                }
                if(input == "3")
                {
                    foreach(Assignment assignment in assignments)
                    {
                        assignment.ToString();
                    }
                }

                if (input == "4")
                {
                    foreach (Course course in courses)
                    {
                        course.ToString();
                    }
                }

                if (input == "5")
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Input the following student details: Firstname, Lastname, Date of Birth(mm/dd/yyyy) and Tuition Fess");
                    string firstname = Console.ReadLine();
                    string lastname = Console.ReadLine();
                    string dateOfBirth = Console.ReadLine();
                    string tuitionFees = Console.ReadLine();
                    Student newStudent = new Student(firstname, lastname, Convert.ToDateTime(dateOfBirth), Convert.ToInt32(tuitionFees));
                    students.Add(newStudent);

                    Console.WriteLine("New student details");
                    newStudent.ToString();
                }

                
                if(input == "6")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Input the following course details: Title, Stream , Type ,StartDate (mm/dd/yyyy) and EndDate(mm/dd/yyyy)");
                    string title = Console.ReadLine();
                    string stream = Console.ReadLine();
                    string type = Console.ReadLine();
                    string startDate = Console.ReadLine();
                    string endDate = Console.ReadLine();

                    Course newCourse = new Course(title, stream, type, Convert.ToDateTime(startDate), Convert.ToDateTime(endDate));
                    courses.Add(newCourse);
                }

                if (input == "7")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Input the following assignment details: Title, Description and Submission date, Oral mark and Total mark");
                    string title = Console.ReadLine();
                    string description= Console.ReadLine();
                    string subDate = Console.ReadLine();
                    string oralMark = Console.ReadLine();
                    string totlaMakr = Console.ReadLine();


                    Assignment newAssignment = new Assignment(title, description, Convert.ToDateTime(subDate), Convert.ToInt32(oralMark), Convert.ToInt32(totlaMakr));
                    assignments.Add(newAssignment);
                }

                if (input == "8")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Input the following trainer details: Firstname, Lastname and Subject");
                    string firstName = Console.ReadLine();
                    string lastName = Console.ReadLine();
                    string subject = Console.ReadLine();
                   

                  Trainer newTrainer = new Trainer(firstName, lastName, subject);
                  trainers.Add(newTrainer);
                }
                
                if(input == "9")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Give Course title");
                    string courseTitle = Console.ReadLine();
                    int courseFound = FindCourse(courseTitle);

                    if (courseFound == -1)
                    {
                        Console.WriteLine("Course was not found");
                    }
                    else
                    {
                        Console.WriteLine("Course found");
                        Console.WriteLine("Give student details Firstname and Lastname ");
                        string firstname = Console.ReadLine();
                        string lastname = Console.ReadLine();

                        int studentFound = FindStudent(firstname, lastname);

                        if(studentFound == -1)
                        {
                            Console.WriteLine("Student was not found");
                        }
                        else
                        {
                            courses[courseFound].AddStudentToList(students[studentFound]);
                        }
                       
                       

                        //Console.WriteLine("Give student details Firstname, Lastname and Date of birth");
                        //string firstname = Console.ReadLine();
                        //string lastname = Console.ReadLine();
                        //string dateofbirth = Console.ReadLine();
                        //Student newStudent = new Student(firstname, lastname, Convert.ToDateTime(dateofbirth));
                        //courses[courseFound].AddStudentToList(newStudent);
                    }

                }

                if (input == "10")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Give Course title");
                    string courseTitle = Console.ReadLine();
                    int courseFound = FindCourse(courseTitle);

                    if (courseFound == -1)
                    {
                        Console.WriteLine("Course was not found");
                    }
                    else
                    {
                        Console.WriteLine("Course found");
                        Console.WriteLine("Give trainer details: Firstname and Lastname ");
                        string firstname = Console.ReadLine();
                        string lastname = Console.ReadLine();

                        int trainerFound = FindTrainer(firstname, lastname);

                        if (trainerFound == -1)
                        {
                            Console.WriteLine("Trainer was not found");
                        }
                        else
                        {
                            courses[courseFound].AddTrainerToList(trainers[trainerFound]);
                        }
                    }

                }


                if (input == "11")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Give Course title");
                    string courseTitle = Console.ReadLine();
                    int courseFound = FindCourse(courseTitle);

                    if (courseFound == -1)
                    {
                        Console.WriteLine("Course was not found");
                    }
                    else
                    {
                        Console.WriteLine("Course found");
                        Console.WriteLine("Give assignement name ");
                        string title = Console.ReadLine();
                        

                        int assignmentFound = FindAssignment(title);

                        if (assignmentFound == -1)
                        {
                            Console.WriteLine("Assignement was not found");
                        }
                        else
                        {
                            courses[courseFound].AddAssignmentToList(assignments[assignmentFound]);
                        }
                    }

                }

                if (input == "12")
                {
                    foreach(Course course in courses)
                    {
                        Console.WriteLine(course.GetTitle());
                        course.PrintStudentsPerCourse();
                    }
                }

                if (input == "13")
                {
                    foreach (Course course in courses)
                    {
                        Console.WriteLine(course.GetTitle());
                        course.PrintTrainersPerCourse();
                    }
                }

            }

           
        }
    }
}
