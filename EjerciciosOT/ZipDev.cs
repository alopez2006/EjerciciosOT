namespace EjerciciosOT
{
    static class ZipDev
	{

		/*
			A hemispherical dome is inscribed into a regular square pyramid. The base of the pyramid is a square 
			with edge of length A. The distance from the pyramid apex to the center of the square is equal to H. 
			The dome is a hemisphere with its center coinciding with the center of the base which touches all 
			faces of the pyramid (except for the base). Calculate the radius of the dome.

			The only line of input contains two space-separated integers: A and H. 1 <= A <= 50, 1 <= H <= 50.

			Output the radius of the dome inscribed in the given pyramid with exactly 4 digits after decimal point. 

			Example
				A = 15
				H = 10
				radius = 6
		*/
		public static double GetRadius(int A, int H)
        {
			double radius;

			radius = A + H;

			return radius;
        }

		/*
			input: the eagle eats snakes
			output: 4

			input: snakes seldom munch on north highland ducks
			output: 3
		*/
		public static int GetSequence(string words)
		{
			int resul = 1;
			string[] parts = words.Split(' ');

			if (parts.Length < 1 || parts.Length > 10) return 0;

			for (; resul < parts.Length; resul++)
			{
				if (parts[resul].Substring(0, 1).ToLower() != parts[resul - 1].Substring(parts[resul - 1].Length - 1).ToLower())
					break;
			}

			return resul;
		}
	}
}
