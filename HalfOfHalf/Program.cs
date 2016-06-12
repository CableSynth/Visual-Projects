using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfOfHalf {
    class Program {
        static void Main(string[] args) {
            int numOfExpress = int.Parse(Console.ReadLine());
            string[] arr = new string[numOfExpress];
            string[] newStr = new string[numOfExpress];

            for(int i = 0; i < numOfExpress; ++i) {
                arr[i] = Console.ReadLine();
            }

            for(int i = 0; i < numOfExpress; ++i) {
                int length = (arr[i].Length) / 2;
                for (int j = 0; j < length; j++) {
                    if(j%2 == 0) {
                        newStr[i] += arr[i][j];
                    }
                }
            }

            for(int i = 0; i < numOfExpress; ++i) {
                Console.WriteLine(newStr[i]);
            }
        }
    }
}
