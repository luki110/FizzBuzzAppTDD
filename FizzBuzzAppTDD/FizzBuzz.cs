using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzAppTDD
{
    public class FizzBuzz
    {
        private readonly List<ICondition> _conditions;
        public FizzBuzz()
        {
            _conditions = new List<ICondition>
            {
                new FizzBuzzCondition(),
                new FizzCondition(),
                new BuzzCondition()
            };
        }

        public string GetOutput(int number)
        {
            foreach (var condition in _conditions)
            {
                var result = condition.Apply(number);
                if (!string.IsNullOrEmpty(result))
                {
                    return result;
                }
            }

            return number.ToString();
        }
    }
}
