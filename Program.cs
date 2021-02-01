using System;

namespace AccountManangement
{
    class Program

    {
        static void Main(string[] args)
        {

            AccountHolderRepository accountHolder = new AccountHolderRepository();

            

            //ManagerRepository manager = new ManagerRepository();
            try
            {

                //Console.WriteLine("enter your preffered id");
                Console.WriteLine("Enter your ID");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your First Name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter your Last Name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter your Middle Name");
                string middleName = Console.ReadLine();

                Console.WriteLine("Enter your Date of Birth");
                DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());    

                Console.WriteLine("Enter your Email");
                string email = Console.ReadLine();

                Console.WriteLine("Enter your PhoneNumber");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Enter your Address");
                string address = Console.ReadLine();

                Console.WriteLine("Enter your Password");
                string password = Console.ReadLine();

                Console.WriteLine("Confirm Your Password");
                string checkPassword = Console.ReadLine();









                //accountHolder.CreateAccountHolder(001, "olaoluwa", "ajefera", "lionel", new DateTime(2020 - 09 - 12), "ola@gmail.com", "090876543321", "lekki phase1", "read","read");
                //accountHolder.CreateAccountHolder(002, "adejimi", "olamide", "cristiano", new DateTime(2020 - 09 - 12), "olafemi@gmail.com", "08076543212", "magodo phase1", "pass", "pass");
                accountHolder.CreateAccountHolder(id, firstName, lastName, middleName, dateOfBirth, email, phoneNumber, address, password, checkPassword);
                //Console.WriteLine("Congratulations.. Registration Succesful");
                accountHolder.List();

                ////accountHolder.UpdateAccountHolder(001, "adeyi", "ojo", "olafemi@gmail.com", "Gbonogun Abeokuta", "09028041932");
                ////accountHolder.RemoveAccountHolder(002);



                //manager.CreateManager(001, "Ade", "Kola", "Oluseyi", "oluseyi@gmail.com", "dearie223");
                //manager.List();



                Console.ReadKey();

            }
            catch (Exception )
            {
                Console.WriteLine("Registration Failed Due to Wrong Input");    
            }

        }
    }
}
