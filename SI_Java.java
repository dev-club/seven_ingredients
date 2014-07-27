
class SI_Java {

	public static void main(String[] args) {
		
		// <- These make the rest of the line a comment

		/*  <- This symbol opens a multi-line comment
		This symbol closes a multi-line comment -> */

		// Variables
		int x = 5;
		String y = "Hello World!";
		boolean z = false;

		// Conditionals
		if (x > 4) {
			System.out.println(y);
		}
		else if (x == 3) {
			System.out.println("!dlroW olleH");
		}
		else {
			System.out.println("X is not greater.");
		}

		/* 
		Another conditional that compares the variable, x in this case, to
		each possible case to choose what to do.  Default is equivalent to else
		*/
		switch(x) {
			case 4:
				System.out.println("Four");
				break;
			case 5:
				System.out.println("Five");
				break;
			default:
				System.out.println("Does not match.");
				break;	
		}

		// Methods declared outside main, see below
		printSeven();
		x = returnNum(6);
		System.out.println(String.valueOf(x));	

		// Data Structure (holds groups of data)
		/*
		type "int" stores a single number
		type "int[]" stores an array, or group, of numbers
		*/
		int[] data = {1, 2, 3, 4, 5};

		// Loops
		for (int i = 0; i < data.length; i++) {
			System.out.println(String.valueOf(data[i]));
		}

		while (x > 0) {
			System.out.println(String.valueOf(x));
			x--;
		}

		// Documentation
		System.out.println("http://docs.oracle.com/javase/7/docs/index.html");

		/*
		Execution (after installation)
		javac <name of file>.java
		java <name of file>	
		*/	

	}

	public static void printSeven() {
		// void is the return type, how we know what to expect back from the method
		System.out.println("Seven");
		return;
	}

	public static int returnNum(int num) {
		// this method accepts a number as an argument, (int num), and returns that number
		return num;
	}

}
