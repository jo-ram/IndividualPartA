using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA.Entities
{
    class Trainer
    {
        private string _firstName;
        private string _lastName;
        private string _subject;

        public Trainer(string firstName, string lastName, string subject)
        {
            _firstName = firstName;
            _lastName = lastName;
            _subject = subject;
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

        public void ToString()
        {
            Console.WriteLine($"Trainers' Fullname: {_firstName} {_lastName}");
        }
    }
}
