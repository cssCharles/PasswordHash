using System;
using System.Security.Cryptography;
namespace PasswordHash
{
	class Program
	{
		static void Main(string[] args)
		{
			bool Invalid = true;
			string theHash = PasswordHash.CreateHash("ChaRLi3IzG0D");
			Console.WriteLine(theHash);
			while (Invalid)
			{
				
				Console.Clear();
				Console.WriteLine("Enter Password");
				string PW = Console.ReadLine();

				if (PasswordHash.ValidatePassword(PW, theHash))
				{
					Console.WriteLine("Welcome");
					Invalid = false;
				}
				else
				{
					Console.WriteLine("Invalid Password");
			Console.ReadLine();
				}
			}

			Console.ReadLine();
		}


	}

}
