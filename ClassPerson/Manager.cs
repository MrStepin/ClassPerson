using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    public class Manager : Worker
    {

        private double _value;

        private List<Worker> listOfWorkers = new List<Worker>() { };

        public Manager () { }

        public Manager(Manager manager)
        {
            Leader = manager;
        }

        public override double Salary
        {
            get
            {
                return _value;
            }
            set
            {
                if ((Leader != null) && (listOfWorkers.Count != 0))
                {
                    foreach (Worker worker in listOfWorkers)
                    {
                        if ((Leader.Salary <= value) || (worker.Salary >= value))
                        {
                            throw new Exception();
                        }
                    }
                }
                _value = value;
            }
        }

        public void DismissWorker(Worker worker)
        {
            listOfWorkers.Remove(worker);
        }

        public void HireWorker(Worker worker)
        {
            if (!listOfWorkers.Contains(worker))
            {
                if (worker.Leader != Leader)
                {
                    if (worker.Leader != null)
                    {
                        worker.Leader.DismissWorker(worker);
                    }
                    worker.Leader = this;
                }
                listOfWorkers.Add(worker);
            }
        }
    }
}
