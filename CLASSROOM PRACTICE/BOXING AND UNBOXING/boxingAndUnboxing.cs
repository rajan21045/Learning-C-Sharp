/*
It is anact of converting value type instance to a reference type instance.
Eg. 
int x = 9;
object obj = x; // box the int

Unboxing:
int y = (int)obj;

eg2:
object obj = 9;
long x = (long) obj; // Invalid cast exception
then
object obj = 9;
long x = (int)obj;
As does this:
object obj =3.5;
int x= (int)(double)obj;

*/

using System;

class Test
{
    static void Main()
    {
        //Boxing And Unboxing
        int x= 8;
        object obj = x;
        int y = (int)obj;
        object obj1 = 3.5;
        int z= (int)(double)obj1;
    }
}