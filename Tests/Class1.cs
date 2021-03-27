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
        Worker worker1 = new Worker();
        Worker worker2 = new Worker();
        Worker worker3 = new Worker();

        Manager manager = new Manager();

        [Test]
        public void CheckManagerSalary()
        {
            manager.Hire(worker1);
            manager.Hire(worker2);
            manager.Hire(worker3);

            worker1.Salary = 100;
            manager.Salary = 90;
            Assert.That(() => worker1.Salary, Throws.Exception);
            Assert.That(() => manager.Salary, Throws.Exception);
        }
    }
}