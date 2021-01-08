using System.Linq;

namespace EjerciciosOT
{
    static class NearShore
    {

		/*
			input: aabbb 
			output: bbbaa

			input: a
			output: a

			input: abcdef
			output: fedcba 
		*/
		// return str.SequenceEqual(str.Reverse());
		public static string ReverseString(string str)
		{
			string aux = "";

			for (int i = str.Length - 1; i >= 0; i--)
				aux += str.Substring(i, 1);

			return aux;
		}
	}
}
