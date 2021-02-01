using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManangement
{
    public class ManagerRepository
    {
        public List<Manager> Managers;

        public ManagerRepository()
        {
            Managers = new List<Manager>();
        }

        public void Read(Manager manager)
        {
            Console.WriteLine($"{manager.GetId()}, {manager.GetFirstName()}, {manager.GetLastName()}, {manager.GetMiddleName()}, {manager.GetEmail()}, {manager.GetPassword()}");
        }

       

            public void List()
        {
            foreach (Manager manager in Managers)
            {
                Read(manager);
            }
        }

        public void CreateManager(int id, string firstName, string lastName, string middleName, string email, string password)
        {
            Manager manager = new Manager(id, firstName, lastName, middleName, email,password);

            
            Managers.Add(manager);

            
        }

        

       


        

    }
}
