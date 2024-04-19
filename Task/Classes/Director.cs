using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task
{

    public delegate string OperationWithMoney(int amount);

    public class Director
    {
        public OperationWithMoney promote;
        public OperationWithMoney penalize;

        public string Promote(int amount) => promote?.Invoke(amount);
        public string Penalize(int amount) => penalize?.Invoke(amount);
    }
}
