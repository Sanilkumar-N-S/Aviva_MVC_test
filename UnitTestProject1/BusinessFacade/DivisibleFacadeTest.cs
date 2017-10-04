using FizzBuzzApplication.BusinessFacade.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestProject1.BusinessFacade
{
   public class DivisibleFacadeTest
    {
        [Fact]
        public void FailedCase()
        {
            var divisibleFacade = new DivisibleFacade();
            var result = divisibleFacade.Division(10);
            Assert.NotNull(result);
        }
    }
}
