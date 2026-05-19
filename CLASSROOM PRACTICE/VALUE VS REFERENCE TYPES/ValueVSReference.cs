// Value VS Reference
using System;
class Test{
	public int x;
}
class Program{
	static void Main(){
		// value Type Example
		int a = 10;
		int b = a;
		b = 20;
		Console.WriteLine("Value Type:");
		Console.WriteLine("a: "+a);
		Console.WriteLine("b: "+b);

		// Reference Type Example
		Test t1 = new Test();
		t1.x = 10;
		
		Test t2 = t1;
		t2.x = 20;
		Console.WriteLine("Reference Type:");
		Console.WriteLine("t1.x : "+t1.x);
		Console.WriteLine("t2.x : "+ t2.x);


	}
}
