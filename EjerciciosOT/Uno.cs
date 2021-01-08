using System;

namespace EjerciciosOT
{
    static class Unosquare
    {
        /*
            input: helloworld!
            output:
                    h
                    el
                    low
                    orld
                    ! 
         */
        public static void PrintStr(string str)
        {
            int num = 0;

            for (int i = 1; i <= str.Length; i++)
            {
                if ((num + i) >= str.Length)
                {
                    i = num + i;
                    Console.WriteLine(str.Substring(num));
                }
                else
                    Console.WriteLine(str.Substring(num, i));

                num += i;
            }
        }


        /*
            input: aabbccc
            output: 2a2b3c
    
            input: aabcc
            output: 2ab2c
    
            input : aabbcccaab
            output: 2a2b3c2ab 
        */
        public static string CountString(string str)
        {
            string result = "";
            int count = 1;

            for (int i = 0; i < str.Length; i++)
            {
                string letter = (i + 1) < str.Length ? str[i + 1].ToString() : "";

                if (str[i].ToString() == letter && letter != "")
                {
                    count++;
                }
                else
                {
                    result += (count == 1 ? "" : count.ToString()) + str[i];

                    count = 1;
                }
            }

            return result;
        }
    }
}
