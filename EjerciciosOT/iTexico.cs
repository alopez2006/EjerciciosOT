using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOT
{
    static class iTexico
    {
		public static string ReverseStringBuilder(string str)
		{
			StringBuilder auxStr = new StringBuilder();

			for (int i = str.Length - 1; i >= 0; i--)
			{
				auxStr.Append(str.Substring(i, 1));
			}

			return auxStr.ToString();
		}

		public static string ReverseStringStack(string str)
		{
			Stack pila = new Stack();
			StringBuilder auxStr = new StringBuilder();

			for (int i = 0; i < str.Length; i++)
			{
				pila.Push(str.Substring(i, 1));
			}

			foreach (string val in pila)
			{
				auxStr.Append(val.ToString());
			}

			return auxStr.ToString();
		}

	}
}
