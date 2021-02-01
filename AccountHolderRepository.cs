using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManangement
{
    public class AccountHolderRepository
    {
        // how to create a new list
        public List<AccountHolder> AccountHolders;

        public AccountHolderRepository()
        {
            AccountHolders = new List<AccountHolder>();
        }


        public void Read(AccountHolder accountHolder)
        {
            Console.WriteLine($"{accountHolder.GetId()} {accountHolder.GetFirstName()} {accountHolder.GetLastName()} {accountHolder.GetMiddleName()} {accountHolder.GetDateOfBirth()} {accountHolder.GetEmail()} {accountHolder.GetPhoneNumber()}  {accountHolder.GetAddress()} {accountHolder.GetPassword()}");
        }

        public void List()
        {
            foreach (AccountHolder accountHolder in AccountHolders)
            {
                Read(accountHolder);
            }
        }

        public void CreateAccountHolder(int id, string firstName, string lastName, string middleName, DateTime dateOfBirth, string email, string phoneNumber, string address, string password, string checkPassword)
        {
            AccountHolder accountHolder = new AccountHolder(id, firstName, lastName, middleName, dateOfBirth, email, phoneNumber, address, password);

            if (password == checkPassword)
            {
                var accountHolders = FindByIdOrEmail(id, email);

                if (accountHolders == null)
                {
                    AccountHolders.Add(accountHolder);
                }
                else
                {
                    Console.WriteLine($"Account owner with this id {id} or  email {email} already exists.");
                }
            }
            else
            {
                Console.WriteLine("Password did not match...Registration Failed");
            }


        }

        public AccountHolder FindByIdOrEmail(int id, string email)
        {
            return AccountHolders.Find(i => i.GetId() == id || i.GetEmail() == email);
        }

        public void UpdateAccountHolder(int id, string firstName, string lastName, string email, string address, string phoneNumber)
        {
            var update = FindByIdOrEmail(id, email);
            update.SetFirstName(firstName);
            update.SetLastName(lastName);
            update.SetAddress(address);
            update.SetPhoneNumber(phoneNumber);
        }

        public void RemoveAccountHolder(int id, string email)
        {

            AccountHolders.Remove(FindByIdOrEmail(id,email));
                
            Console.WriteLine($"User with id {id}  Deleted");
           
        }
     
    }
    
}
