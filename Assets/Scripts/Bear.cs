using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Animal   // <-----LOADS of INHERITANCE coming from this Animal parent class ;-)

{
    //  public Color Color; // <-------- Might use this later to change the material color


    public void CatchFish()
    {
        Debug.Log("I just caught a fish");//need to replace with unique animation
    }
}
