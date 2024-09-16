using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class DequeTestt
    {
        public static void Main(string[] args)
        {
            DequePinca<int> dq = new DequePinca<int>(5);

            dq.AddFront(1);
            dq.AddFront(2);
            dq.AddFront(3);
            dq.AddFront(4);
            dq.AddFront(5);

            dq.Display();

            dq.RemoveBack();

            dq.Display();


        }
    }
}
