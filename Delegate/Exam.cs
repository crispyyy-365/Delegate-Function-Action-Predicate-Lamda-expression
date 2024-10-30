using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                value = StartDate.AddHours(Duration);
                _endDate = value;
            }
        }
    }
}