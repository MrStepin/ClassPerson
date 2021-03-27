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

        public void Dismiss(Worker worker)
        {
            ListOfWorkers.Remove(worker);
        }

        public void Hire(Worker worker)
        {
            ListOfWorkers.Add(worker);
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
                        throw new Exception("Increase salary!");
                    }
                }
                _value = value;
            }
        }
    }
}
