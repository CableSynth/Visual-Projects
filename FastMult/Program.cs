using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FastMult {
    class Program {
        static void Main(string[] args) {
            int numOfSets = int.Parse(Console.ReadLine());
            BigInteger[] nums = new BigInteger[numOfSets];
            for(int i = 0; i < numOfSets; ++i) {
                string[] arrStr = new string[2];
                  arrStr = Console.ReadLine().Split(' ');
                BigInteger firstNum = BigInteger.Parse(arrStr[0]);
                BigInteger secNum = BigInteger.Parse(arrStr[1]);
                nums[i] = firstNum * secNum;
           }
            for(int i = 0; i < numOfSets; ++i) {
                Console.WriteLine(nums[i]);
            }
           // Console.WriteLine("{/0}\n", nums);
        }
    }
}
