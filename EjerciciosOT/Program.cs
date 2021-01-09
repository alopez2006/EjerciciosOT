using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace EjerciciosOT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(numberRepeat(1536, 6));
            //Console.WriteLine(SumaRecursiva(5));
            //Console.WriteLine(3 * -5);
            //Console.WriteLine(multiplyNumbers(3, -5));
            //Console.WriteLine(findBigger(new int[] { 140, 3, 500 }));
            //almostIncreasingSequence(new int[] { 10, 1, 2, 3, 4, 5 });

            //Console.WriteLine(NearShore.ReverseString("aabbb"));

            //Unosquare.PrintStr("HelloWorld!");
            //Console.WriteLine(Unosquare.CountString("aabbccc"));

            //Console.WriteLine(iTexico.ReverseStringStack("aabbb"));

            //Console.WriteLine(BairesDev.validBracketSequence("]"));

            //Console.WriteLine(BairesDev.stringsConstruction("c", "abccbac")); // 3
            //Console.WriteLine(BairesDev.stringsConstruction("abc", "abccba")); // 7

            //int[][] p = new int[3][];
            //p[0] = new int[2] { 0, 11 };
            //p[1] = new int[2] { -7, 1 };
            //p[2] = new int[2] { -5, -3 };

            //int[][] p = new int[5][];
            //p[0] = new int[2] { 19, -15 };
            //p[1] = new int[2] { 4, 9 };
            //p[2] = new int[2] { 13, -7 };
            //p[3] = new int[2] { -3, -1 };
            //p[4] = new int[2] { -10, 30 };
            //Console.WriteLine(BairesDev.closestPointPair(p));

            //Apex.FormatArrays();

            //ApexAnalisis analisis = new ApexAnalisis();
            //Console.WriteLine(analisis.GetValue());

            //ApexSingleton apexSingleton1 = ApexSingleton.GetInstance();
            //ApexSingleton apexSingleton2 = ApexSingleton.GetInstance();

            //Console.WriteLine(apexSingleton2.Message);
            //apexSingleton2.Message = "Updated";

            //Console.WriteLine($"Message in apexSingleton1: { apexSingleton1.Message }");
            //Console.WriteLine($"Message in apexSingleton2: { apexSingleton2.Message }");

            //int[] nodes = { 3, 3, -1, 2, 2 };
            int[] nodes = { 5, 6, 6, 2, 3, -1, 2 };

            Console.WriteLine($"Complete nodes: { Asignet.GetFullNodes(nodes) }");
        }

        

        public static int multiplyNumbers(int number1, int number2)
        {
            int resul = 0;

            for (int i = 0; i < Math.Abs(number2); i++)
            {
                resul += Math.Abs(number1);
            }

            if (number1 < 0 || number2 < 0) resul *= -1;

            return resul;
        }


        public static int findBigger(int[] array)
        {
            int resul = 0;

            resul = array.Aggregate((acc, x) => acc > x ? acc : x);

            return resul;
        }

        /*
            How many times is the number 6 written from 1 to 1536?
            input: 1536, 6 
            output: 404 
        */
        public static int numberRepeat(int maxNumber, int number)
        {
            int num = 0;

            for (int i = 0; i <= maxNumber; i++)
            {
                num += Regex.Matches(i.ToString(), number.ToString()).Count;
            }

            return num;
        }

        /*
            intput: 4 
                4 + 3 + 2 + 1 
            output: 10
        */
        public static int SumaRecursiva(int numero)
        {
            return numero == 1 ? numero : numero + SumaRecursiva(--numero);
        }

        public static bool almostIncreasingSequence(int[] sequence)
        {
            List<int> num = new List<int>();

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] >= sequence[i])
                {
                    num.Add(i == 1 ? 0 : i);

                    if (num.Count > 1) return false;
                }
            }

            var foos = new List<int>(sequence);
            foos.RemoveAt(num[0]);
            sequence = foos.ToArray();

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] >= sequence[i])
                {
                    num.Add(i);

                    if (num.Count > 1) return false;
                }
            }

            return true;
        }

        public static bool CheckPaliandrome(string str)
        {
            string aux = "";

            str = str.Replace(" ", "").ToLower();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            aux = new string(arr);

            /*for (int i = str.Length - 1; i >= 0; i--)
                aux += str.Substring(i, 1);*/

            return str.Equals(aux);
        }

        public static int GetFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return (GetFibonacci(n - 1) + GetFibonacci(n - 2));
            }
        }

        public static string GetFibonacciC(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n.ToString();
            }
            else
            {
                return (GetFibonacciC(n - 1) + " " + GetFibonacciC(n - 2));
            }
        }
    }
}
