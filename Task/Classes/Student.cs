using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Student
    {
        public string Name { get; private set; }
        public int Scholarship { get; private set; }

        public Student(string name, int scholarship)
        {
            Name = name;
            Scholarship = scholarship;
        }

        public void SubscribeToDirector(Director director)
        {
            if (director is null)
                return;

            director.promote += PromoteHandler;
        }

        public void UnsubscribeToDirector(Director director)
        {
            if (director is null)
                return;

            director.promote -= PromoteHandler;
        }

        private string PromoteHandler(int amount)
        {
            Scholarship += amount;
            return $"Добавка к стипендии. Текущая стипендия {Scholarship}";
        }
    }
}
