using System;
namespace CTUDUnderstanding
{
    /// <summary>
    /// Patient Model Class
    /// </summary>
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Remarks { get; set; }

        public string Phone { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Patient()
        {

        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="remarks"></param>
        /// <param name="phone"></param>
        public Patient(int id, string name, int age, string gender, string remarks, string phone)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Remarks = remarks;
            Phone = phone;
        }

        public override string ToString()
        {
            return "Id " + Id +
                "\nName " + Name +
                "\nAge " + Age +
                "\nGender " + Gender +
                "\nPhone" + Phone +
                "\nComment " + Remarks;
               
        }

        /// <summary>
        /// Takes all the information about the patient from the console
        /// </summary>
        public virtual void TakePatientDetailsFromUser() 
        {
            int id;
            //id = Convert.ToInt32(Console.ReadLine());
            //bool result = Int32.TryParse(Console.ReadLine(), out id);

            Console.WriteLine("Please enter the ID");
            while(!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry for Id. Try again...");
              
            }

            Id = id;

            Console.WriteLine("Please enter your name ");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter your gender. M/F ");
           
            Gender = Console.ReadLine();

            int age;
            Console.WriteLine("Please enter the Age");
            while (!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid entry for age. Try again...");

            }

            Age = age;

            Console.WriteLine("Please Enter your phone number ");
            Phone = Console.ReadLine();

            Console.WriteLine("Please enter any comment ");
            Remarks = Console.ReadLine();
        }

    }
}
