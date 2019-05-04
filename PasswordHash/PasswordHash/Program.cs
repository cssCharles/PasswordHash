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
				
				//let's hide the password while it's being typed
				string PW = null;
				while (true)
				{
					var key = Console.ReadKey(true);
					if (key.Key == ConsoleKey.Enter)
						break;
					PW += key.KeyChar;
				} //End Hide password

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
