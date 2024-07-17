using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzAppTDD
{
    public class BuzzCondition : ICondition
    {
        public string Apply(int number)
        {
            return number % 5 == 0 ? "Buzz" : null;
        }
    }
}
