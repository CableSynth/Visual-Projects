using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharPattern {
    class Program {
        static void Main(string[] args) {
            int numOfBoards = int.Parse(Console.ReadLine());
            string[][] lenWidth = new string[numOfBoards][];

            for (int i = 0; i < numOfBoards; ++i) {
                lenWidth[i] = Console.ReadLine().Split(' ');               
            }

            for (int i = 0; i < numOfBoards; i++) {

            }
        }
        static char[][] arrOfChar(int len, int width) {
            char[][] arr = new char[width][];
            for (int i = 0; i < width; i++) {
                for (int j = 0; j < len; j++) {
                    if (width%2 == 0) {

                    }
                }
            }
        }
    }
}
