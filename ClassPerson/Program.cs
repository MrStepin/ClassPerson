using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Manager manager2 = new Manager(manager);
            Worker worker1 = new Worker(manager);
            Worker worker2 = new Worker(manager2);
            Worker worker3 = new Worker(manager);

            Console.WriteLine(manager.Leader);


            manager.Name = "Mr.Boss";
            manager.Salary = 200;
            manager.Age = 40;
            manager.Seniority = 10;

            manager2.Name = "NEW";

            worker1.Name = "Mr.Ivan";

            worker1.Salary = 100;
            worker1.Age = 30;
            worker1.Seniority = 1;

            worker2.Name = "Mr.Oleg";

            worker2.Salary = 150;
            worker2.Age = 20;
            worker2.Seniority = 2;

            worker3.Name = "Mr.Vasya";

            worker3.Salary = 100;
            worker3.Age = 30;
            worker3.Seniority = 1;

            manager2.HireWorker(worker1);
            manager.HireWorker(worker2);
            manager2.HireWorker(worker2);
            manager2.HireWorker(manager);

            Console.ReadKey();

        }
    }
}