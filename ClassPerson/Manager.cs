using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    public class Manager : Employee
    {
        private List<Worker> ListOfWorkers = new List<Worker>() { };
        private List<Manager> ListOfManagers = new List<Manager>() { };

        public void Dismiss(Worker worker)
        {
            ListOfWorkers.Remove(worker);
        }

        public void HireWorker(Worker worker)
        {
            if (!ListOfWorkers.Contains(worker))
            {
                ListOfWorkers.Add(worker);
            }
        }

        public void DismissManager(Manager manager)
        {
            ListOfManagers.Remove(manager);
        }

        public void HireManager(Manager manager)
        {
            if (!ListOfManagers.Contains(manager))
            {
                ListOfManagers.Add(manager);
            }
        }

        private double _value;

        public double Salary
        {
            get
            {
                return _value;
            }
            set
            {
                foreach (Manager manager in ListOfManagers)
                {
                    if (manager.Salary >= value)
                    {
                        throw new Exception();
                    }
                    
                }
                foreach (Worker worker in ListOfWorkers)
                {
                    if (worker.Salary >= value)
                    {
                        throw new Exception();
                    }
                }
                _value = value;
            }
        }
    }
}
