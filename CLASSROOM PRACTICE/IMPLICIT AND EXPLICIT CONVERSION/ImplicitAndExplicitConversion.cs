// Implicit And Explicit Conversion

using System;
class TypeConversion{
	static void Main(){
		// Implicit Conversion
		int num = 25;
		float f = num; 	// automatic conversion
		Console.WriteLine("Implicit Conversion ( Int To Float ): " + f);

		// Explicit Conversion
		float value = 10.75f;
		int i = (int)value;
		Console.WriteLine("Explicit Conversion (float To Int): "+ i);
		int j = Convert.ToInt32(num);
		Console.WriteLine("Explicit Conversion (float To Int): "+ j);

	}
}