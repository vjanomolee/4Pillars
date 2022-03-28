using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Animal

{
    public Color Color;

    public override void MakeSoundAndUI()
    {
        Debug.Log("roar"); // need to replace this code with audio play and UI display
    }

    public void CatchFish()
    {
        Debug.Log("I just caught a fish");//need to replace with unique animation
    }
}
