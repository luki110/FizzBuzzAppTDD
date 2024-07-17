using FizzBuzzAppTDD;
using System.Reflection;

Type fizzBuzzType = typeof(FizzBuzz);

// Create an instance of the FizzBuzz class
object fizzBuzzInstance = Activator.CreateInstance(fizzBuzzType);

// Get the GetOutput method
MethodInfo getOutputMethod = fizzBuzzType.GetMethod("GetOutput");

if (getOutputMethod != null)
{
    // Invoke the GetOutput method for a range of numbers and print the results
    for (int i = 1; i <= 100; i++)
    {
        string result = (string)getOutputMethod.Invoke(fizzBuzzInstance, new object[] { i });
        Console.WriteLine(result);
    }
}