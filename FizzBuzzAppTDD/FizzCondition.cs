using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzAppTDD
{
    public class FizzCondition : ICondition
    {
        public string Apply(int number)
        {
            return number % 3 == 0 ? "Fizz" : null;
        }
    }
}
