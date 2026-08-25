/*
Anonymous Method In C#
It is a method Which doesn't contains any name.
it is defined as:       delegate(Parameters_list){
code.....
}
E.g
*/
using System; 
class Test
{
    public delegate void Bestie(string name);
    static void Main()
    {
        Bestie p = delegate (string name)
        {
            Console.WriteLine("My Best Friend Is {0}", name);
        };

        p("Ashok Poudel");
    }
}