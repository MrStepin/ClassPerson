using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    class Manager : Employee
    {
        public List<Worker> ListOfWorkers = new List<Worker>(){};

        public void Dismiss(Worker worker)
        {
            ListOfWorkers.Remove(worker);
        }

        public void Hire(Worker worker)
        {
            ListOfWorkers.Add(worker);
        }

        public void SetSalary(Manager manager, double salary)
        {
            foreach (Worker worker in ListOfWorkers)
            {
                if (worker.Salary >= manager.Salary)
                {
                    Console.WriteLine("Increase salary");
                }
                else
                {
                    manager.Salary = salary;
                }
            }
        }
    }
}
