using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  NUnit.Framework;
using ClassPerson;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void CheckAssertOnWorkerSalary()
        {
            Manager manager = new Manager();
            Worker worker1 = new Worker(manager);
            Worker worker2 = new Worker(manager);
            Worker worker3 = new Worker(manager);   
            manager.Hire(worker1);
            manager.Hire(worker2);
            manager.Hire(worker3);
            manager.Salary = 90;
            Action workerSalary = () => { worker1.Salary = 100; };
            OwnAssert.Throws(workerSalary);
        }

        [Test]
        public void CheckManagers()
        {
            Manager manager1 = new Manager();
            Manager manager2 = new Manager();
            Manager manager3 = new Manager();
            Manager manager4 = new Manager();
            List<Manager> ListOfAllHiredManagers = new List<Manager>() { };

            manager1.HireSubordinateManagers(manager2, ListOfAllHiredManagers);
            manager1.HireSubordinateManagers(manager3, ListOfAllHiredManagers);
            manager1.HireSubordinateManagers(manager4, ListOfAllHiredManagers);
            manager2.HireSubordinateManagers(manager3, ListOfAllHiredManagers);
            manager4.HireSubordinateManagers(manager3, ListOfAllHiredManagers);

            Assert.Contains(manager2, manager1.ListOfManagers);
        }
    }
}