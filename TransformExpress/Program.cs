//Ok.......So, we need to store the '(' and pop for each ')'
//Also we need to store the characters that are used for the expressions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformExpress {
    class Program {
        static void Main(string[] args) {
            int numOfEpress = int.Parse(Console.ReadLine());
            string[] arrOfExpress = new string[numOfEpress];
            Stack<char> stackOfepress = new Stack<char>();
            Stack<char> parenthes = new Stack<char>();
            Stack<char> symbols = new Stack<char>();
                        

            for (int i = 0; i < numOfEpress; ++i) {
                arrOfExpress[i] = Console.ReadLine();
            }

            for (int i = 0; i < numOfEpress; i++) {
                string evalStr = arrOfExpress[i];
                for (int j = 0; j < evalStr.Length; j++) {
                    char test = evalStr[j];
                    switch (test) {
                        case '(':
                            parenthes.Push('(');
                            break;
                        case ')':
                            parenthes.
                        default:
                            break;
                    }
                }
            }
        }
    }
}
