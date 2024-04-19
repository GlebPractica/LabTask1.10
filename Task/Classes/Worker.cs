using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Worker
    {
        public string Name { get; private set; }
        public int Salary { get; private set; }

        public Worker(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public void SubscribeToDirector(Director director)
        {
            if (director is null)
                throw new ArgumentNullException("Unkown argument. Try again.\nCode Error: WSubTD");

            director.promote += PromoteHandler;
            director.penalize += PenalizeHandler;
        }

        public void UnsubscribeToDirector(Director director)
        {
            if (director is null)
                throw new ArgumentNullException("Unkown argument. Try again.\nCode Error: WUnSubTD");

            director.promote -= PromoteHandler;
            director.penalize -= PenalizeHandler;
        }

        private string PromoteHandler(int amount)
        {
            Salary += amount;
            return $"Успешно добавлена зарплата работнику {Name}. Текущая зарплата {Salary}";
        }

        private string PenalizeHandler(int amount)
        {
            Salary -= amount;
            return $"Был наложен штраф работнику {Name}. Текущая зарплата {Salary}";
        }
    }
}
