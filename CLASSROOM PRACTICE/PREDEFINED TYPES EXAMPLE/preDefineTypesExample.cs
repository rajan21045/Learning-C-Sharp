using System; 

class Program   
{
    static void Main()       {
       string message = "Hello, World! ";
	string upperMessage = message.ToUpper();
	Console.WriteLine(upperMessage);
	int x = 2015;
	string message1 = message + x.ToString();
	Console.WriteLine(message1);
	}
}