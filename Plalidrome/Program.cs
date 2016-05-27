//Try Really Big Numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Plalidrome {
    class Program {
        static void Main(string[] args) {
            
            string numOfPali = Console.ReadLine();
            int arrSize = int.Parse(numOfPali);
            BigInteger front = 0, rear = 0;
            int lengths;
            BigInteger[] nextPalidrome = new BigInteger[arrSize];
            string[] arrOfNum = new string[arrSize];

            //Read in the strings to evalate for a palidrom
            for(int i = 0; i < arrSize; ++i) {
                arrOfNum[i] = Console.ReadLine();
            }

            //Find number of digets in each set of Numbers
            //Need to write a fucntion or set to evaluate the first half
            //and second half of the number to see which is greater.
            //if first half is greater then use it as the new palidrome
            //second half..... increment the first half and make new palidrome
            //find new exception for the 9's
            for(int i  = 0; i < arrSize; ++i) {
                lengths = arrOfNum[i].Length;
                if (BigInteger.Parse(arrOfNum[i]) == 0 || lengths == 1) {
                    nextPalidrome[i] = 11;
                }else if(lengths%2 == 0) {
                    string subNum = arrOfNum[i].Substring(0, (lengths / 2));
                    string subBack = arrOfNum[i].Substring(lengths / 2);
                    string rearStr = strReverse(subBack);
                    //rear = reverse(BigInteger.Parse(subBack));
                    rear = int.Parse(rearStr); front = BigInteger.Parse(subNum);
                    if (rear >= front && lengths != 1) {
                        ++front;
                        if (front.ToString().Length > subNum.Length) {
                            BigInteger temp = BigInteger.Parse(front.ToString().Remove(subNum.Length));
                            string rev = strReverse(temp);
                            nextPalidrome[i] = BigInteger.Parse(front.ToString() + rev);
                        } else {
                            string rev = strReverse(front);
                            nextPalidrome[i] = BigInteger.Parse(front.ToString() + rev);
                        }
                    }else {
                        string rev = strReverse(front);
                        nextPalidrome[i] = BigInteger.Parse(front.ToString() + rev);
                    }
                    //For single digits
            } else {
                    int half = (lengths / 2) + 1;
                    string subNum = arrOfNum[i].Substring(0, half);
                    string subBack = arrOfNum[i].Substring(half);
                    string rearStr = strReverse(subBack);
                    //rear = reverse(BigInteger.Parse(subBack));
                    rear = BigInteger.Parse(rearStr);
                    front = BigInteger.Parse(subNum);
                    BigInteger subFront = BigInteger.Parse(subNum.Substring(0, (subNum.Length - 1)));
                    if(subFront < rear) {
                        string rev = strReverse(subFront);
                        nextPalidrome[i] = BigInteger.Parse(front.ToString() + rev);
                    }else if(subFront >= rear  {
                        front++;
                        if (front.ToString().Length > subNum.Length) {
                            BigInteger temp = BigInteger.Parse(front.ToString().Remove(half-1));
                            string rev = strReverse(temp);
                            nextPalidrome[i] = BigInteger.Parse(front.ToString() + rev);
                        } else {
                            string rev = strReverse(subFront);
                            nextPalidrome[i] = BigInteger.Parse(front.ToString() + rev);
                        }
                    }
                }
            }

            for(int i = 0; i < arrSize; ++i) {
                Console.WriteLine(nextPalidrome[i]);
            }
            
        }
        static BigInteger reverse(BigInteger num) {
            BigInteger change = num;
            BigInteger rev = 0;
            while (change > 0) {
                BigInteger rm = change % 10;
                rev = rev * 10 + rm;
                change = change / 10;
            }
            return rev;
        }
        static string strReverse(BigInteger num) {
            char[] arr = num.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static string strReverse(string str) {
            char[] newStr = str.ToCharArray();
            Array.Reverse(newStr);
            return new string(newStr);
        }
       // static BigInteger nexPal()
    }
}
