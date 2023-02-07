using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// This is the model for my calculator. asp.net allows me to get and set everything at once. I am using system.ComponentModel to set a range from 0-100 
namespace Mission4.Models
{
    public class calculatorModel
    {
        [Range(0, 100, ErrorMessage ="Value must be between 0 and 100")]
        public int A { get; set; }
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100")]
        public int G { get; set; }
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100")]
        public int Q { get; set; }
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100")]
        public int M { get; set; }
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100")]
        public int F { get; set; }
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100")]
        public int I { get; set; }


    }
}
