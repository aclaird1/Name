// See https://aka.ms/new-console-template for more information
using system;

	Global Class Sample
	{
		Void Main(string[], args)
		{ 
			// 1 add a string variable for your name 
			String myName = GetName();

			System.console.writeline("Hellow World my Name is: " + myName);

		}
		Public Static string GetName(),
		{
			String myName;
			// 2 add a print statement t0 tell you enter your name
			SPriystem.Console.WriteLine("Please Enter Your Name:");

			// 3 Now the readline statement will read in your name
			myName = Console.ReadLine();

			return myName;
		}
	}


