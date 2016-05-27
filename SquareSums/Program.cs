using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSums {
    class Program {
        static void Main(string[] args) {
            string[] endPts = Console.ReadLine().Split(' ');
            int front = int.Parse(endPts[0]);
            int back = int.Parse(endPts[1]);
            int sum = 0;
            for (int i = front; i <= back; i++) {
                sum += (i*i);
            }
            Console.WriteLine(sum);
        }
    }
}
