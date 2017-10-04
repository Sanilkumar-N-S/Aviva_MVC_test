using FizzBuzzApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApplication.BusinessFacade.Interface
{
   public interface IDivisibleFacade
    {
        Fizz_Buzz_Model Division(int input);
    }
}
