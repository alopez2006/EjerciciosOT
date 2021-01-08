using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EjerciciosOT
{
    static class BairesDev
    {

        public static int addTwoDigits(int n)
        {
            string num = n.ToString();

            if (num.Length == 2)
            {
                return int.Parse(num.Substring(0, 1)) + int.Parse(num.Substring(1));
            }

            return 0;
        }

        /*
            Given a string sequence consisting of the characters '(', ')', '[', ']', '{', and '}'. 
            Your task is to determine whether or not the sequence is a valid bracket sequence.

            The Valid bracket sequence is defined in the following way:
                An empty bracket sequence is a valid bracket sequence.
                If S is a valid bracket sequence then (S), [S] and {S} are also valid.
                If A and B are valid bracket sequences then AB is also valid.

            Example
                For sequence = "()", the output should be validBracketSequence(sequence) = true;
                For sequence = "()[]{}", the output should be validBracketSequence(sequence) = true;
                For sequence = "(]", the output should be validBracketSequence(sequence) = false;
                For sequence = "([)]", the output should be validBracketSequence(sequence) = false;
                For sequence = "{[]}", the output should be validBracketSequence(sequence) = true.
                For sequence = "[[(({()}))]]{()}[({})]", the output should be validBracketSequence(sequence) = true.

            [execution time limit] 3 seconds (cs)

            [input] string sequence
                A bracket sequence, consisting of the characters (, ), [, ], {, and }.

            Guaranteed constraints:
                0 ≤ sequence.length ≤ 106. 
        */
        public static bool validBracketSequence(string sequence)
        {
            Dictionary<string, string> brackets = new Dictionary<string, string>()
            {
                { "(", ")" },
                { "[", "]" },
                { "{", "}" },
            };
            string initBracket = "";
            Stack<string> auxBrackets = new Stack<string>();

            for (int i = 0; i < sequence.Length; i++)
            {
                if (initBracket == "")
                {
                    bool valid = false;
                    foreach (KeyValuePair<string, string> bracket in brackets)
                    {
                        if (bracket.Key == sequence.Substring(i, 1))
                        {
                            valid = true;
                            break;
                        }
                    }
                    if (valid) initBracket = sequence.Substring(i, 1);
                    else return false;
                }
                else
                {
                    foreach (KeyValuePair<string, string> bracket in brackets)
                    {
                        if (bracket.Key == sequence.Substring(i, 1))
                        {
                            auxBrackets.Push(initBracket);
                            initBracket = sequence.Substring(i, 1);

                            break;
                        }
                        if (bracket.Value == sequence.Substring(i, 1))
                        {
                            if (bracket.Key != initBracket) return false;
                            else initBracket = "";

                            if (auxBrackets.Count > 0) initBracket = auxBrackets.Pop();
                        }
                    }
                }
            }

            return initBracket.Length == 0;
        }

        /*
            Given two strings a and b, both consisting only of lowercase English letters, your task 
            is to calculate how many strings equal to a can be constructed using only letters from 
            the string b? Each letter can be used only once and in one string only.

            Example
                For a = "abc" and b = "abccba", the output should be stringsConstruction(a, b) = 2.
                    We can construct 2 strings a = "abc" using only letters from the string b.
                For a = "ab" and b = "abcbcb", the output should be stringsConstruction(a, b) = 1.
                For a = "zkz" and b = "zpaskazgazkazggaaksiokkzzzzaaazzpkuazzzgzkzabrgzzq", 
                    the output should be stringsConstruction(a, b) = 7.
                For a = "c" and b = "abccbac", the output should be stringsConstruction(a, b) = 3.

            [execution time limit] 3 seconds (cs)

            [input] string a
                String to construct, containing only lowercase English letters.

            Guaranteed constraints:
                1 ≤ a.length ≤ 105.

            [input] string b
                String containing needed letters, containing only lowercase English letters.

            Guaranteed constraints:
                1 ≤ b.length ≤ 105. 
        */
        public static int stringsConstruction(string a, string b)
        {
            int num = 0;

            List<string> str = new List<string>();

            GetPermutation(a, ref str);

            foreach (string x in str)
            {
                num += Regex.Matches(b, x).Count;

                //for (int i = 0; i < b.Length; i++)
                //{
                //    if (b.Substring(i, x.Length) == x) num++;
                //    if (i + x.Length == b.Length) i = b.Length;
                //}
            }

            return num;
        }

        static void GetPermutation(string rest, ref List<string> str, string prefix = "")
        {
            if (string.IsNullOrEmpty(rest))
            {
                if (!str.Contains(prefix))
                {
                    str.Add(prefix);
                }
            }

            for (int i = 0; i < rest.Length; i++)
            {
                GetPermutation(rest.Remove(i, 1), ref str, prefix + rest[i]);
            }
        }

        /*
            You have an array p of points on a Cartesian plane. 
            Find and return the minimum possible Euclidian distance between two points with different indices in p.
                dist((x, y), (a, b)) = √(x - a)² + (y - b)²

            Example
                For p = [[0, 11], [-7, 1], [-5, -3]], the output should be closestPointPair(p) = 4.472135955.
                For = [[19,-15], [4,9], [13,-7], [-3,-1], [-10,30]], the output should be closestPointPair(p) = 10

            [execution time limit] 3 seconds (cs)

            [input] array.array.integer p
                Every inner array p[i] contains exactly 2 integers: the x and y coordinates of the ith point.

            Guaranteed constraints:
                2 ≤ p.length ≤ 2 · 104,
                p[i].length = 2,
                |p[i][j]| ≤ 107.
        */

        /*
            int[][] p = new int[3][];
            p[0] = new int[2] { 0, 11 };
            p[1] = new int[2] { -7, 1 };
            p[2] = new int[2] { -5, -3 };

            int[][] p = new int[5][];
            p[0] = new int[2] { 19, -15 };
            p[1] = new int[2] { 4, 9 };
            p[2] = new int[2] { 13, -7 };
            p[3] = new int[2] { -3, -1 };
            p[4] = new int[2] { -10, 30 };
        */
        public static double closestPointPair(int[][] p)
        {
            
            List<double> dists = new List<double>();

            for (int i = 0; i < p.Length; i++)
            {
                for (int y = i + 1; y < p.Length; y++)
                {
                    if (i != y)
                    {
                        double dist = Math.Sqrt(Math.Pow(p[i][0] - p[y][0], 2) + Math.Pow(p[i][1] - p[y][1], 2));
                        dists.Add(dist);
                    }
                }
            }

            return dists.OrderBy(p => p).FirstOrDefault();
        }
    }
}
