using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Time {
    class Program {
        static void Main(string[] args) {
            int tests = int.Parse(Console.ReadLine());
            int[] sums = new int[tests];
            for(int i = 0; i < tests; ++i) {
                int numOfStudents = int.Parse(Console.ReadLine());
                string[] arrTime = Console.ReadLine().Split(' ');
                int[] timeIn = Array.ConvertAll(arrTime, element => int.Parse(element));
                string[] arrNeed = Console.ReadLine().Split(' ');
                int[] timeNeeded = Array.ConvertAll(arrNeed, element => int.Parse(element));
                int time = 0;
                int sum = 0;
                for (int j = 0; j < numOfStudents; j++) {
                    int allot = timeIn[j] - time;
                    if(allot >= timeNeeded[j]) {
                        ++sum;
                    }
                    time = timeIn[j];
                }
                sums[i] = sum;
            }
            for (int i = 0; i < tests; ++i) {
                Console.WriteLine(sums[i].ToString());
            }
            
        }
    }
}
