using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA.Entities
{
    class Assignment
    {
        private string _title;
        private string _description;
        private DateTime _subDateTime;
        private int _oralMark;
        private int _totalMark;

        public Assignment(string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            _title = title;
            _description = description;
            _subDateTime = subDateTime;
            _oralMark = oralMark;
            _totalMark = totalMark;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetFees(string newTitle)
        {
            _title = newTitle;
        }
        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }

        public void ToString()
        {
            Console.WriteLine($"Assignments: {_title} \n {_description}");
        }

    }
}
