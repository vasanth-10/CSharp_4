using System;
using calculator;

namespace calculator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			cal c = new cal ();
			Console.WriteLine("Enter the value of a");
			int a = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine("Enter the value of b");
			int b = Convert.ToInt32(Console.ReadLine ());
			Console.WriteLine("Choose the operation  " +
				"1 for Addition  " +
				"2 for subtraction   " +
				"3 for multiplication  " +
				"4 for divison ");
			int o = Convert.ToInt32(Console.ReadLine ());
			if (o == 1) {
				c.sum (a, b);
			}  
			else if (o == 2) {
				c.sub (a, b);
			
			}
			else if (o == 3) {
				c.mul(a,b);

			}
			else if (o == 4) {
				c.div(a,b);
			}
			else  {
				Console.WriteLine ("You entered wron operation");

			}
			
			Console.ReadLine ();
		}
	}
}

