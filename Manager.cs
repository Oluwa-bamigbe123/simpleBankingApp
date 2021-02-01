using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManangement
{
    public class Manager
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private string MiddleName;
        private string Email;
        private string Password;

        public Manager( int id, string firstName, string lastName, string middleName, string email, string password)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Email = email;
            this.Password = password;
        }
        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public string GetFirstName()
        {
            return FirstName;
        }
        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public void SetLastName(string lastName)
        {
            this.FirstName = lastName;
        }
        public string GetMiddleName()
        {
            return MiddleName;
        }
        public void SetMiddleName(string middleName)
        {
            this.FirstName = middleName;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            this.Email = email;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void SetPaasword(string password)
        {
            this.Password = password;
        }
    }
}
