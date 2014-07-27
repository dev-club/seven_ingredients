class SI_CSharp {

	public static void main(string[] args) {
		
		// <- These make the rest of the line a comment

		/*  <- This symbol opens a multi-line comment
		This symbol closes a multi-line comment -> */

		// Variables
		int x = 5;
		string y = "Hello World!";
		bool z = false;

		// Conditionals
		if (x > 4) {
			Console.WriteLine(y.ToString());
		}
		else if (x == 3) {
			Console.WriteLine("!dlroW olleH");
		}
		else {
			Console.WriteLine("x is less than 3.");
		}

		/* 
		Another conditional that compares the variable, x in this case, to
		each possible case to choose what to do.  Default is equivalent to else
		*/
		switch(x) {
			case 4:
				Console.WriteLine("Four");
				break;
			case 5:
				Console.WriteLine("Five");
				break;
			default:
				Console.WriteLine("Does not match.");
				break;	
		}

		// Methods declared outside main, see below
		printSeven();
		x = returnNum(6);
		Console.WriteLine(x.ToString());

		// Data Structure (holds groups of data)
		/*
		type "int" stores a single number
		type "int[]" stores an array, or group, of numbers
		*/
		int[] data = {1, 2, 3, 4, 5};

		// Loops
		for (int i = 0; i < data.Length; i++) {
			Console.WriteLine(data[x].ToString());
		}

		while (x > 0) {
			Console.WriteLine(x.ToString());
			x--;
		}

		// Documentation
		Console.WriteLine("http://msdn.microsoft.com/en-us/library/kx37x362.aspx");

		/*
		Execution - Install Visual Studio Express
		*/	

	}

	public static void printSeven() {
		// void is the return type, how we know what to expect back from the method
		Console.WriteLine("Seven");
		return;
	}

	public static int returnNum(int num) {
		// this method accepts a number as an argument, (int num), and returns that number
		return num;
	}
}
