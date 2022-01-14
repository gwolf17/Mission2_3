using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2_3.Models
{
    public class CalculatorModel
    {
        [Required]
        [Range (0,100)] //Values must be between 0-100
        public int assignments { get; set; }
        [Required]
        [Range(0, 100)]
        public int groupProject { get; set; }
        [Required]
        [Range(0, 100)]
        public int quizzes { get; set; }
        [Required]
        [Range(0, 100)]
        public int exams { get; set; }
        [Required]
        [Range(0, 100)]
        public int intex { get; set; }
    }
}
