using System; // Needed for Console.Write/Read
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenNumbers

{ // Loop to find even numbers in a range of 1 to 100
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) // If remainder of i divided by 2 is equal to 0 (meaning that it's an even number), then execute the loop
            {
                Console.WriteLine(i);       // Printing the even number as per above condition
                Console.Read();
            }

        }
    }
}

public class OddNumbers

{ // Loop to find odd numbers in a range of 1 to 100
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0) // If remainder of i divided by 2 is NOT equal to 0 (meaning that's an odd number), then execute the loop
            {
                Console.WriteLine(i);       // Printing the odd number as per above condition
                Console.Read();
            }
        }
    }
}

