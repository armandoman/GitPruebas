using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EployeeQuiz.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public string Position { get; set; }
        public double Wage { get; set; }
        public char Sex { get; set; }
        public string PhotoPath { get; set; }
    }
}