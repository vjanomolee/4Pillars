using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goat : Animal// <-----LOADS of INHERITANCE coming from this Animal parent class ;-)

{
    public GameObject blood;
    public Transform bloodSpawn;
    public override void MakeSoundAndUI()
    {
        base.MakeSoundAndUI();
        Instantiate(blood, bloodSpawn.position, Quaternion.identity);
    }
    public void SomeUniqueGoatMethod()
    {
        Debug.Log("I convert food into spheres");//need to replace with unique animation
    }
}
