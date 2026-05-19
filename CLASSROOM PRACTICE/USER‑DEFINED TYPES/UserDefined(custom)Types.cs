// User Defined(custom) Types
using System;
public class UnitConverter{
		int ratio;				     // Field
			public UnitConverter(int unitRatio){ // Constructor
				ratio = unitRatio;
				}
			public int Convert( int unit){
					return unit * ratio;
				}
		}

class Test{
		static void Main()
			{
			UnitConverter fToI = new UnitConverter(12);
			UnitConverter mToF = new UnitConverter(52800);
			Console.WriteLine(fToI.Convert(30));
			Console.WriteLine(fToI.Convert(100));
			Console.WriteLine(fToI.Convert(mToF.Convert(1)));
		}
}
