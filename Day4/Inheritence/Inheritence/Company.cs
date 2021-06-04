using System;
namespace UnderstandRelationProject
{
    class Company
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public Person Employee { get; set; }
        public Company()

        {
            Employee = new Person();
            Employee.Name = "ABC";
            Employee.Age = 45;
            Console.WriteLine("Please enter a number");
            Employee.Check = Convert.ToInt32(Console.ReadLine());
            Employee.PrintCheck();
        }
    }
}
