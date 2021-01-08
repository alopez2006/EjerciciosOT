using System;

namespace EjerciciosOT
{
    static class Apex
	{

		public static void ShortArrays()
		{
			int[] a = new int[] { 5, 8, 25, 245 };
			var b = new int[] { 2, 7, 9, 12, 20, 21, 27 };

			for (int i = 0; i < a.Length; i++)
			{
				for (int j = 0; j < b.Length; j++)
				{
					if (a[i] > b[j])
					{
						int c = a[i];

						a[i] = b[j];
						b[j] = c;
					}
				}
			}

			//Array.Sort(a);
			Array.Sort(b);

			Console.WriteLine(String.Join(",", a));
			Console.WriteLine(String.Join(",", b));
		}

	}

	public class ApexAnalisis
    {
		static int value = 0;

		public ApexAnalisis()
        {
			if (value == 0)
				value = 10;

			value += 20;
        }

		static ApexAnalisis()
		{
			value = 5;
		}

		public int GetValue()
        {
			return value;
        }

    }

	public class ApexSingleton
	{

        public string Message { get; set; }

        private static ApexSingleton _instance;

		private ApexSingleton() 
		{
			Message = "Instanced";
		}

		public static ApexSingleton GetInstance()
		{
			if (_instance == null)
			{
				_instance = new ApexSingleton();
			}
			return _instance;
		}
	}

}
