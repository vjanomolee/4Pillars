using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Animal   // <-----LOADS of INHERITANCE coming from this Animal parent class ;-)

{
    public GameObject blood;
    public Transform bloodSpawn;
    public override void MakeSoundAndUI()
    {
        base.MakeSoundAndUI();
        Instantiate(blood, bloodSpawn.position, Quaternion.identity);
    }

    public void CatchFish()
    {
        Debug.Log("I just caught a fish");//need to replace with unique animation
    }
}
