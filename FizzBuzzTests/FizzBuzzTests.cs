using FizzBuzzAppTDD;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();

        }

        [Test]
        public void NumberDivisibleByThree_ShouldReturnFizz()
        {
            var actual = "Fizz";

            var result = _fizzBuzz.GetOutput(3);

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        public void NumberDivisibleByFive_ShouldReturnBuzz()
        {
            var actual = "Buzz";

            var result = _fizzBuzz.GetOutput(5);

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        public void NumberDivisibleByThreeAndFive_ShouldReturnFizzBuzz()
        {
            var actual = "FizzBuzz";

            var result = _fizzBuzz.GetOutput(15);

            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        public void NumberNotDivisibleByThreeOrFive_ShouldReturnNumber()
        {
            var actual = "1";
            var result = _fizzBuzz.GetOutput(1);


            Assert.That(actual, Is.EqualTo(result));
        }
    }
}
