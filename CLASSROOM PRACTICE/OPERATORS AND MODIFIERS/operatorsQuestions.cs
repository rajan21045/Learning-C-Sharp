using System;
class Program{
	static void Main(){

		//Q1. WAP to display which one is greater between 2 numbers by user
		Console.WriteLine();
		Console.Write("Hey, Enter The First Number: ");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Hey, Enter The Second Number: ");
		int b = Convert.ToInt32(Console.ReadLine());
		if(a>b){
			Console.WriteLine("Hey, {0} Is Greater Than {1}", a, b);
		}else if(b>a){
			Console.WriteLine("Hey, {0} Is Greater Than {1}", b, a);
		}else{
			Console.WriteLine("Hey, Both Are Equal");
		}
		
		//Q2. WAP to display which one is greater between 3 numbers by user
		Console.WriteLine();
		Console.Write("Hey, Enter The First Number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Hey, Enter The Second Number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Hey, Enter The Third Number: ");
		int num3 = Convert.ToInt32(Console.ReadLine());
		if(num1>num2 && num1>num3){
			Console.WriteLine("Hey, {0} Is Greater Than {1} & {2}", num1, num2, num3);
		}else if(num2>num1 && num2>num3){
			Console.WriteLine("Hey, {0} Is Greater Than {1} & {2}", num2, num1, num3);
		}else if(num3>num1 && num3>num2){
			Console.WriteLine("Hey, {0} Is Greater Than {1} & {2}", num3, num1, num2);
		}else{
			Console.WriteLine("Hey, All Are Equal");
		}
		
		// Q3. WAP to check whether a given number is divisible by 7 or 5 or not.
		Console.WriteLine();
		Console.Write("Hey, Enter The First Number: ");
		int n1 = Convert.ToInt32(Console.ReadLine());
		if(7 % n1 == 0 || 5 % n1 == 0){
			Console.WriteLine("Hey, It (7 or 5) is divisible by {0}.", n1);
		}else{
			Console.WriteLine("Hey, It (7 or 5) is not divisible by {0}.", n1);
		};
	}
}
