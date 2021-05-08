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

        private List<Manager> listOfManagers = new List<Manager>() { };

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
                if ((Leader != null) && (listOfManagers.Count != 0))
                {
                    foreach (Manager manager in listOfManagers)
                    {
                        if ((Leader.Salary <= value) || (manager.Salary >= value))
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

        public void DismissManager(Manager manager)
        {
            listOfWorkers.Remove(manager);
        }

        public void HireWorker(Worker worker)
        {
            if (!listOfWorkers.Contains(worker))
            {
                if (worker.Leader != Leader)
                {
                    worker.Leader.DismissWorker(worker);
                    worker.Leader = this;
                }
                listOfWorkers.Add(worker);
            }
        }

        public void HireManager(Manager manager)
        {
            if (!listOfWorkers.Contains(manager))
            {
                if (manager.Leader != null)
                {
                    manager.Leader.DismissManager(manager);
                    manager.Leader = this;
                }
                listOfManagers.Add(manager);
            }
        }
    }
}
