using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script follows the 'Strings and Concatenation' and 'String Manipulation' videos for the 'Unity 2018 Game Development' course on Udemy. They focus on using and combining strings (concatenation).

public class StringsAndConcatenation : MonoBehaviour
{
    public string myString = "Hey guys";
    public string myString2 = "What's up";

    // Use this for initialization
    void Start()
    {
        print("myString" +myString2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
