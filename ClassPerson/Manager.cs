using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    public class Manager : Worker
    {
        private double _value;
        private Manager _manager;

        private List<Worker> ListOfWorkers = new List<Worker>() { };

        public Manager() { }
        public Manager(Manager manager)
        {
            _manager = manager;
        }

        public double Salary
        {
            get
            {
                return _value;
            }
            set
            {
                if (_manager != null)
                {
                    if (_manager.Salary <= value)
                    {
                        throw new Exception();
                    }

                    _value = value;
                }
            }
        }

        public void DismissWorker(Worker worker)
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
    }
}
