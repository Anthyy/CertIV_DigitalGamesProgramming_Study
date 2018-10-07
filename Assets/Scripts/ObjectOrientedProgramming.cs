using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script implements the challenge at the end of the 'Object Oriented Programming' video for the 'Master Unity Game Development - Ultimate Beginners Bootcamp' StackSkills course:

/* 1. Create a method called 'PrintGame'. This method will print in the console the type of game you want to make the most.
 * 2. Execute 'PrintGame' in the 'Start' method.
 * 3. Run game to see the result in the console.
 * 4. Create a public variable of type "string" called "myGameIdea".
 * 5. Go to the inspector and enter a value.
 * 6. Modify your "PrintGame" method to show the value of "myGameIdea" in the console.
*/

public class ObjectOrientedProgramming : MonoBehaviour
{
    [Header("My Game")] // Headers don't need semi-colons (btw, this was just something I was playing around with myself).

    public string myGameIdea; // Because this is public, this will show in the inspector once you attach the script to a game object.
    
    void Start()
    {
        PrintGame(); // Calling the PrintGame() function/method we created down the bottom.
    }
    
    void Update()
    {

    }

    public void PrintGame() // Functions/methods don't need semi-colons either.
    {
        print(myGameIdea);
    }
}
