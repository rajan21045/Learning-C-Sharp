/*
String s = "hello";
Console.WriteLine(s[0]); // Output: h
Console.WriteLine(s[1]); // Output: e

Syntax:

<modifier> <return type> this [arguments list]
{
get { // code to return the value }
set { // code to set the value }
}

*/

class Program
{
    class IndexerClass
    {
        public string[] name = new string[5];
        public string this[int i]
        {
            get
            {
                return name[i];
            }
            set
            {
                name[i] = value;
            }
        }
    }
    static void Main(string[] args)
    {
        IndexerClass obj = new IndexerClass();
        obj[0] = "Rajan";
        obj[1] = "Ashok";
        obj[2] = "John";
        obj[3] = "Subesh";
        obj[4] = "Alice";
        for(int i=0; i<5; i++)
        {
            Console.WriteLine(obj[i]);
            Console.ReadKey();
        }

    }
}