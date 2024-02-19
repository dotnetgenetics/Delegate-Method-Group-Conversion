using System;

namespace DelegateMethodGroupConversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Action<string> studentOne = EvaluateStudent;
            studentOne("Greg Esguerra");
            Action<string> studentTwo = EvaluateStudent;
            studentTwo("Michelle Esguerra");

            //studentOne and studentTwo refer to same delegate instance
            Console.WriteLine(Object.ReferenceEquals(studentOne, studentTwo));
        }

        static void EvaluateStudent(string name)
        {
            Console.WriteLine($"Student for evaluation is {name}");
        }
    }
}
