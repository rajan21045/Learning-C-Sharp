// Q1 WAP for the demonstration of conditional operator & miscellaneous operators

using System;
class Miscoperator{
		static void Main(){
			//size of operator
			Console.WriteLine("Size of Int: "+ sizeof(int));
			Console.WriteLine("Size of Double: "+ sizeof(double));

			// type of operator
			Type t = typeof(string);
			Console.WriteLine("Type of Int: "+ t);
	
			// is operator
			object num = 50;
			if (num is int){
				Console.WriteLine("Num is An INTEGER.");
			}
	
			//Conditional operator
			int a = 10;
			int b = 20;
			int max = (a>b)?a:b;
			Console.WriteLine("Maximum Value is "+ max);
	}
}