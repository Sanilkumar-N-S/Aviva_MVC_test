using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FizzBuzzApplication.Models
{
    public class Fizz_Buzz_Model
    {
        [Required(ErrorMessage = "Value must be set")]
        [Range(0, 1000, ErrorMessage = "Value must be between 0 and 250")]
        public int Input_Number { get; set; }
        public IList<string> Result { get; set; }
    }
}