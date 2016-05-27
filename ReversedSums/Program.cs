using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedSums {
    class Program {
        static void Main(string[] args) {
            int sets = int.Parse(Console.ReadLine());
            string[][] numStr = new string[sets][];
            int[,] numsToRev = new int[sets, 2];
            int[] sums = new int[sets];
            for (int i = 0; i < sets; ++i) {
                numStr[i] = Console.ReadLine().Split(' ');
                for (int j = 0; j < 2; j++) {
                    numsToRev[i, j] = int.Parse(numStr[i][j]);
                }
            }
            for (int i = 0; i < sets; i++) {
                int num1, num2, sum;
                num1 = reverse(numsToRev[i, 0]);
                num2 = reverse(numsToRev[i, 1]);
                sum = num1 + num2;
                sums[i] = reverse(sum);
            }
            for (int i = 0; i < sets; i++) {
                Console.WriteLine(sums[i]);
            }

        }
        static int reverse(int num) {
            int change = num;
            int rev = 0;
            while (change > 0) {
                int rm = change % 10;
                rev = rev * 10 + rm;
                change = change / 10;
            }
            return rev;
        }
    }
}
