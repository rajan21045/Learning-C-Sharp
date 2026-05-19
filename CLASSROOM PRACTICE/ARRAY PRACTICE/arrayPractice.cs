using System;
class arrayPractice
{
    static void Main(string[] args)
    {

        // Rectangual
        int[,] num = new int[3, 2]
        {
            {1 , 2},
            {1, 3},
            {2, 5}
        };
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine(num[j, k]);
            }
            Console.ReadKey();
        }
        Console.WriteLine('\n');


        //Jagged Array
        int[][] arr = new int[][]
        {
          new int[] {1, 2},
          new int[] {1, 2, 3},          
          new int[] {1, 2, 3,4}          
        };
        foreach(int[] array in arr)
        {
            foreach (int e in array)
            {
               Console.WriteLine(e + " "); 
            }
            Console.Write('\n');
        }
        Console.ReadKey();

    }
}