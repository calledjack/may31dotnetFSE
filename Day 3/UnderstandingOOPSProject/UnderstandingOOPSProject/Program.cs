using System;

namespace UnderstandingOOPSProject
{
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        public Program()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add();
            Console.ReadKey();
        }
    }
}
