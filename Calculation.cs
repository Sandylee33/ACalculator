using System;
namespace ACalculator1
{
		public class Calculation
		{

			public int Addition(int a, int b)
			{
				return a + b;
			}

			public int Subtraction(int a, int b)
			{
				return a - b;
			}
			public int Multiplication(int a, int b)
			{
				return a * b;
			}
			public float Division(int a, int b)
			{
				if (b != 0)
				{
					return a / b;
				}
				else { return 0; }

			}

		}


}
