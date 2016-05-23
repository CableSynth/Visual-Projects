using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber {
    class Program {
        static void Main(string[] args) {
            int numOfSets = 0;
            string set = Console.ReadLine();
            numOfSets = int.Parse(set);
            List<int>[] listOfNum = new List<int>[numOfSets];
            string[][] arrOfEP = new string[numOfSets][];
            
            //Finding the endpoints that are to be used
            for(int i = 0; i< numOfSets; ++i) {
                arrOfEP[i] = Console.ReadLine().Split(' ');
            }
            for(int i = 0; i < numOfSets; ++i) {
                int front = int.Parse(arrOfEP[i][0]);
                int back = int.Parse(arrOfEP[i][1]);
                int frt = front;
                listOfNum[i] = new List<int>();
                int index = 0;
                //int[] numberArr;
                //Program pro = new Program();
                for (int j = frt; j <= back; j++) {
                    if (isAPrime(front) == true) {
                        listOfNum[i].Add(front);
                        ++index;
                    }
                    ++front;
                }
            }
            //Console.WriteLine();
            for (int i = 0; i < numOfSets; ++i) {
                for(int j = 0; j <listOfNum[i].Count; ++j) {
                    Console.WriteLine(listOfNum[i][j]);
                }
                Console.WriteLine();
            }

        }
        static bool isAPrime(int testNum) {
            int sqrtOfNum = (int) Math.Sqrt(testNum);
            if (testNum == 1) {
                return false;
            }
            for(int i = 2; i <= sqrtOfNum; ++i) {
                if(testNum%i == 0) {
                    return false;
                }
            }
            return true;
        }
    }
}
