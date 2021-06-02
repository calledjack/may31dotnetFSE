using System;
namespace UnderstandingOOPSProject
{
    public class Calculator
    {
        int num1, num2;

        void TakeInstance()
        {
            Console.WriteLine("Please Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        void PrintResult(int result)
        {
            Console.WriteLine($"The result is {result}");
        }


        public void Add()
        {
            TakeInstance();
            int addition = num1 + num2;
            PrintResult(addition);
        }
        public void Multiply()
        {
            TakeInstance();
            int product = num1 * num2;
            PrintResult(product);
        }

        public Calculator()
        {

        }
    }
}
