using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Define Dictionary collection
        Dictionary<int, string> dObj = new Dictionary<int, string>(5);
 
        //add elements to dictionary
        dObj.Add(1, "Rajan");
        dObj.Add(2, "Raaj");
        dObj.Add(3, "Prabin");
        dObj.Add(4, "Ashok");
        dObj.Add(5, "Abin");

        //Print Data
        for(int i=1; i<dObj.Count; i++)
        {
            Console.Write(dObj[i] + " ");
        }
    }
}