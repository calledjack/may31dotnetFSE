using System;
namespace UnderstandRelationProject
{
    class Person
    {
        //public string Name;
        //public int Age;

        public int Age { get; set; }

        public string Name { get; set; }

        int check;

        public int Check
        {
            get{                
                return check;
            }
            set
                { check = value; }

        }

        

        public void PrintCheck()
        {
            Console.WriteLine($"The checksum is {check}");
        }

        public Person()
        {
        }
    }
}
