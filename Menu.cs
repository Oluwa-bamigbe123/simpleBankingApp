using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManangement
{
    public class Menu
    {
        public static void MenuSwitch()
        {
            bool check = true;

            while (check)
            {

                ShowMainMenu();

                string options = Console.ReadLine();

                if (options.Equals(0))
                {
                    Console.WriteLine("Thanks for using our bank");
                }
                else
                {
                    ShowAccountHolderMenu();
                }
                string subOptions = Console.ReadLine();



            }
        }


        public static void ShowMainMenu()
        {
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Account holder menu");
            Console.WriteLine("2. Account manager menu");
        }

        public static void ShowAccountHolderMenu()
        {
            Console.WriteLine("0. Return");
            Console.WriteLine("1. Create account");
            Console.WriteLine("2. Update account");
            Console.WriteLine("3. Delete account");

        }

        public static void ShowAccountManagerMenu()
        {
            Console.WriteLine("0. Return");
            Console.WriteLine("1. Create manager");
            Console.WriteLine("2. Update manager");
            Console.WriteLine("3. View account holders");
        }
    }
}
