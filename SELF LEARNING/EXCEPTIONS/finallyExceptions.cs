using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] nums = {1, 3, 4, 5, 2};
            Console.Write(nums[6]); 
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Something went wrong.");
        }
        finally
        {
            Console.Write("Finaly Section Run...");
        }
    }
}