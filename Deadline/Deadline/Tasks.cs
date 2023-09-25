using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadline
{
    public class Tasks
    {
        public Tasks (int price, int deadline)
        {
            Price = price;
            Deadline = deadline;
        }


        public int Price { get; set; }
        public int Deadline { get; set; }
    }
}
