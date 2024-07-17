using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzAppTDD
{
    public class FizzBuzzCondition : ICondition
    {
        public string Apply(int number)
        {
            return number % 3 == 0  && number % 5 == 0 ? "FizzBuzz" : null;
        }
    }
}
