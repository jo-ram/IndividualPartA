using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA.Entities
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private int _tuitionFees;

        public Student(string firstName, string lastName, DateTime dateOfBirth, int tuitionFees)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _tuitionFees = tuitionFees;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _tuitionFees = 100;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetFirstName(string newFirstName)
        {
            _firstName = newFirstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public void SetLastName(string newLastName)
        {
            _lastName = newLastName;
        }

        public DateTime GetDateOfBirth()
        {
            return _dateOfBirth;
        }

        public void SetDateOfBirth(DateTime newDateOfBirth)
        {
            _dateOfBirth = newDateOfBirth;
        }

        public int GetFees()
        {
            return _tuitionFees;
        }

        public void SetFees(int newTuitionFees)
        {
            _tuitionFees = newTuitionFees;
        }

        public void ToString()
        {
            Console.WriteLine($"Students' Fullname : {_firstName} {_lastName}");
        }
    }


}
