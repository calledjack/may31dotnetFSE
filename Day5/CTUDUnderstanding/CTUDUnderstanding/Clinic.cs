using System;
namespace CTUDUnderstanding
{
    public class Clinic
    {
        Patient[] patients;
        public Clinic()
        {
            

            Console.WriteLine("Please enter the maximum count of patients");
            int size;

            while(!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Invalid, try again");
            }

            patients = new Patient[size];  
        }

        /// <summary>
        /// Will take all the patients details
        /// </summary>
        public void AddPatients()
        {
            for (int i = 0; i < patients.Length; i++)
            {
                patients[i] = new Patient();
                patients[i].TakePatientDetailsFromUser();
            }
        }

        /// <summary>
        /// Print particular patient detail
        /// </summary>
        public void PrintPatientDetails(Patient patient)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(patient);
            Console.WriteLine("-------------------");

        }

        /// <summary>
        /// Print all Patient detail
        /// </summary>
        public void PrintAllPatientDetails()
        {
            foreach (Patient patient in patients)
            {
                PrintPatientDetails(patient);
            }
        }

        /// <summary>
        /// Find a patient using ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int FindPatientUsingId(int id)
        {
            int index = -1;
            for (int i = 0; i < patients.Length; i++)
            {
                if (patients[i].Id == id)
                {
                    index = i;
                    break;
                }
                
            }
            return index;
        }

        /// <summary>
        /// get Patient ID
        /// </summary>
        /// <returns></returns>
     
        int GetPatientId()
        {
            int id;
            Console.WriteLine("Please Enter patient ID");
            while(!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid, try enter id again");
            }
            return id;
        }

        /// <summary>
        /// Prints the patient details by taking the ID.
        /// </summary>
        public void PrintPatientById()
        {
            Console.WriteLine("Print the patient details by ID");
            int id = GetPatientId();
            int ind = FindPatientUsingId(id);
            if(ind ==-1)
            {
                Console.WriteLine("No patient with the id"+ind);
                return;//return the control back to the calling line OR exit the method
            }
            PrintPatientDetails(patients[ind]);
        }


        public void EditPatientDetail()
        {
            Console.WriteLine("Edit the patient details by ID");
            int id = GetPatientId();
            int ind = FindPatientUsingId(id);
            if (ind == -1)
            {
                Console.WriteLine("No patient with the id" + ind);
                return;//return the control back to the calling line OR exit the method
            }
            Console.WriteLine("Current Patient details");
            Console.WriteLine(patients[ind]);
            string choice;
            Console.WriteLine("Do you want the add more to the comment section? Yes/No");
            choice = Console.ReadLine().ToLower();
            if(choice == "yes")
            {
                Console.WriteLine("Please enter the detail you wish to add on");
                string data = Console.ReadLine();
                patients[ind].Remarks+=data;
                PrintPatientDetails(patients[ind]);
                return;
            }

            Console.WriteLine("Do you want to edit the Phone number? Yes/No");
            choice = Console.ReadLine().ToLower();
            if (choice == "yes")
            {
                Console.WriteLine("Please enter the new phone number");
                patients[ind].Phone = Console.ReadLine();
                PrintPatientDetails(patients[ind]);
                return;
            }

        }

        public void PrintChoiceForUser()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("1. Print all the patient details");
                Console.WriteLine("2. Print a particular patient details");
                Console.WriteLine("3. Edit a particular patient detail");
                Console.WriteLine("0. Exit the application");

                while (!Int32.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Try again. Invalid Entry");
                }
                switch (choice)
                {
                    case 1:
                        PrintAllPatientDetails();
                        break;
                    case 2:
                        PrintPatientById();
                        break;
                    case 3:
                        EditPatientDetail();
                        break;
                    case 0:
                        Console.WriteLine("Bye bye.....");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            } while (choice != 0);
        }
    }

}
