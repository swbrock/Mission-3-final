using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission_3.models
{
    public class CalculatorModel
    {
        [Required]
        [Range(0, 100, ErrorMessage = "Needs to be within 0 and 100")]
        public int Assignments { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Needs to be within 0 and 100")]
        public int Group_Projects { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Needs to be within 0 and 100")]
        public int Quizzes { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Needs to be within 0 and 100")]
        public int Exams { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Needs to be within 0 and 100")]
        public int Intex { get; set; }

    }
}
