using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA.Entities
{
    class Course
    {
        private string _title;
        private string _stream;
        private string _type;
        private DateTime _startDate;
        private DateTime _endDate;

        private List<Student> _students;
        private List<Course> _courses;
        private List<Trainer> _trainers;
        private List<Assignment> _assignments;
        public Course(string tilte,string stream, string type, DateTime startDate, DateTime endDate)
        {
            _title = tilte;
            _stream = stream;
            _type = type;
            _startDate = startDate;
            _endDate = endDate;

            _students = new List<Student>();
            _trainers = new List<Trainer>();
            _assignments = new List<Assignment>();
           
        }


        //public Course()
        //{
        //    _students = new List<Student>();
        //}
        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string newTitle)
        {
            _title = newTitle;
        }
        public string GetStream()
        {
            return _stream;
        }

        public void SetStream(string newStream)
        {
            _stream = newStream;
        }
        public string GetType()
        {
            return _type;
        }

        public void SetType(string newType)
        {
            _type = newType;
        }

        public DateTime GetStartDate()
        {
            return _startDate;
        }

        public void SetStartDate(DateTime newStartDate)
        {
            _startDate = newStartDate;
        }

        public DateTime GetEndDate()
        {
            return _endDate;
        }

        public void SetEndDate(DateTime newEndDate)
        {
            _endDate = newEndDate;
        }

        public void AddStudentToList(Student student)
        {
            _students.Add(student);
        }

        public void PrintStudentsPerCourse()
        {
            foreach(Student student in _students)
            {
                student.ToString();
            }
        }

        public void AddTrainerToList(Trainer trainer)
        {
            _trainers.Add(trainer);
        }

        public void PrintTrainersPerCourse()
        {
            foreach (Trainer trainer in _trainers)
            {
                trainer.ToString();
            }
        }

        public void AddAssignmentToList(Assignment assignment)
        {
            _assignments.Add(assignment);
        }

        public void PrintAssignmentsPerCourse()
        {
            foreach (Assignment assignment in _assignments)
            {
                assignment.ToString();
            }
        }

        public List<Student> GetStudenList()
        {
            return _students;
        }

        public void ToString()
        {
            Console.WriteLine($"Course Details\n Title: {_title} Stream: {_stream} Type: {_type}");
        }
    }
}
