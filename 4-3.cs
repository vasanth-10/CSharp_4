using System;

namespace Application
{
	class Class4
	{
		public void InputX(){
			Console.WriteLine ("Enter the value a");
			int x = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Enter the value b");
			int y = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("X +Y =" + (x+y));
		}


			public static void Main (string[] args)
			{
				Class4 obj = new Class4 ();
				int exitkey = 1;
				while (exitkey > 0) {
					Console.WriteLine ("You want to exit ? Y/N");
					string choice = Console.ReadLine ();
					if (choice.ToLower () == "n") {
						obj.InputX ();
						choice = Console.ReadLine ();
					}  else {
						break;
					}
					Console.ReadLine();
				}
			}
		}
	}

