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
        private Manager _manager;

        private List<Worker> ListOfWorkers = new List<Worker>() { };

        public Action<Worker, Manager> TakeLeader;

        public override double Salary
        {
            get
            {
                return _value;
            }
            set
            {
                if ((_manager != null) && (ListOfWorkers.Count != 0))
                {
                    foreach (Worker worker in ListOfWorkers)
                    {
                        if ((_manager.Salary <= value) || (worker.Salary >= value))
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
            ListOfWorkers.Remove(worker);
        }

        public void HireWorker(Worker worker, Manager manager)
        {
            if (!ListOfWorkers.Contains(worker))
            {
                if (worker.Leader != null)
                {
                    worker.Leader.DismissWorker(worker);
                }
                ListOfWorkers.Add(worker);
                worker.Leader = manager;
            }
        }
    }
}
