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
        public List<Manager> ListOfManagers = new List<Manager>() { };

        public void Dismiss(Worker worker)
        {
            ListOfWorkers.Remove(worker);
        }

        public void Hire(Worker worker)
        {
            ListOfWorkers.Add(worker);
        }

        public void HireSubordinateManagers(Manager manager, List<Manager> ListOfAllHiredManagers)
        {
            if (!ListOfAllHiredManagers.Contains(manager))
            {
                ListOfManagers.Add(manager);
                ListOfAllHiredManagers.Add(manager);
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
