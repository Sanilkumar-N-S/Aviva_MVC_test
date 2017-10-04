using FizzBuzzApplication.BusinessFacade.Interface;
using FizzBuzzApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzzApplication.BusinessFacade.Implementation
{
    public class DivisibleFacade : IDivisibleFacade
    {
        public Fizz_Buzz_Model Division(int input)
        {
            Fizz_Buzz_Model result = new Fizz_Buzz_Model();
            IList<string> ResultList = new List<string>();
            IList<int> NumList = new List<int>();

            for (int i=0; i<= input; i++)
            {
                NumList.Add(i);
            }

            foreach (var item in NumList)
            {
                 if (item % 5 == 0 && item % 3 == 0)
                {
                    ResultList.Add("Fizz Buzz");
                }
               else if (item % 3 == 0)
                {
                    ResultList.Add("Fizz");
                }

                else if (item % 5 == 0)
                {
                    ResultList.Add("Buzz");
                }
               
                else
                {
                    ResultList.Add(item.ToString());
                }
            }
            result.Result = ResultList;
            return result;
        }
    }
}