using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IzhCloud_Timetable.Models.Entities
{
    public class Day
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string FirstFirst { get; set; }
        public string FirstSecond { get; set; }
        public string SecondFirst { get; set; }
        public string SecondSecond { get; set; }
        public string ThirdFirst { get; set; }
        public string ThirdSecond { get; set; }
        public string FourthFirst { get; set; }
        public string FourthSecond { get; set; }
    }
}
