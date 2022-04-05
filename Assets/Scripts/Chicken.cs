using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal// <-----LOADS of INHERITANCE coming from this Animal parent class ;-)
{
    public GameObject feathers;
    public Transform feathersSpawn;
    public override void MakeSoundAndUI()
    {
        base.MakeSoundAndUI();
        Instantiate(feathers, feathersSpawn.position, Quaternion.identity);
    }
}