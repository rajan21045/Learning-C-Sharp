using System;
class Program{
    static void Main(string[] args)
    {
        /* 
            The foreach Loop
            There is also a foreach loop, which is used exclusively to loop through elements in an array (or other data sets):
            Syntax
            foreach (type variableName in arrayName) 
            {
            // code block to be executed
            }
        */
        int[] nums ={1, 2, 3, 4, 5};
        foreach (int item in nums)
        {
            Console.Write(item + " ");
        }
    }
}