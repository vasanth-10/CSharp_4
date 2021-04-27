using System;
using System.IO;
using Application;

namespace Application
{
	class MyException:ApplicationException{
		public void NullException(){
			Console.WriteLine("Exception Occured , Object is null");
		}
	}
	class class3
	{
		
		static void Main()

		{
			class3 c = null ;
			try
			{
				if (c == null)
				{
					throw new MyException();
				}
			}
			catch(MyException ex){
				ex.NullException();
			}



		}
	}
	}

