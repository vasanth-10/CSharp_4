using System;

namespace Products
{
	
	class Product
	{
		public string CustomerType { get; set; }
		public string ProductCode { get; set; }
		public string ProductName { get; set; }
		public int ProductQuantity { get; set; }
		public double ProductPrice { get; set; }
		public int TotalQuantity = 100 ;


		public void GetProductDetails ( string a)
		{
			
			if (a == "1") {
				Console.WriteLine ("Enter Product Name :");
				ProductName = Console.ReadLine ();
				Console.WriteLine ("Enter Product Quantity :");
				ProductQuantity = Convert.ToInt32 (Console.ReadLine ());
				Console.WriteLine ("Enter Product Price :");
				ProductPrice = Convert.ToDouble (Console.ReadLine ());
			}  else if (a == "2") {
				Console.WriteLine ("Enter Product Name :");
				ProductName = Console.ReadLine ();
				Console.WriteLine ("Enter Product Quantity :");
				ProductQuantity = Convert.ToInt32 (Console.ReadLine ());
				Console.WriteLine ("Enter Product Price :");
				ProductPrice = Convert.ToDouble (Console.ReadLine ());
			}  else {
				Console.WriteLine ("You entered wrong selection");
			}

			
		}
	}  


	class Invoice:Product
	{
		
		string CustomerName { get; set; }
		readonly string InvoiceNumber;
		public void PrintInvoice( string a)
		{
			Console.WriteLine("-------------------Invoice------------------------");
			Console.WriteLine("S.No \ t Product Name \ t Quantity \ t Price \ t Total Price \ t Remaining Quantity");
			int index = 1;
			if (a == "1") {

					Console.Write (index);
					Console.Write ("\ t");
					Console.Write (ProductName);
					Console.Write ("\ t\t");
					Console.Write (ProductQuantity);
					Console.Write ("\ t\t");
					Console.Write (ProductPrice);
					Console.Write ("\ t\t");
					Console.Write (ProductPrice * ProductQuantity);
					Console.Write ("\ t\t");
					Console.Write (TotalQuantity - ProductQuantity);
					Console.Write ("\ n");
					index = index + 1;

			}  else if (a == "2") {

					Console.Write (index);
					Console.Write ("\ t");
					Console.Write (ProductName);
					Console.Write ("\ t\t");
					Console.Write (ProductQuantity);
					Console.Write ("\ t\t");
					Console.Write (ProductPrice);
					Console.Write ("\ t\t");
					Console.Write (ProductPrice * ProductQuantity);
					Console.Write ("\ t\t");
					Console.Write (TotalQuantity + ProductQuantity);
					Console.Write ("\ n");
					index = index + 1;

			}
		}
	}
	class User
	{
		public static void Main()
		{
			Console.WriteLine("-------------------Pos Sample Software------------------------");

			Console.WriteLine("Enter Customer type 1 for Buyer 2 for whole seller :");
			string Type  =  Console.ReadLine();

				Product product = new Product();
			Invoice invoice = new Invoice ();
			product.GetProductDetails( Type);
			invoice.PrintInvoice (Type);

		}
	}
}
