using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : Animal
{
    public GameObject greenBlood;
    public Transform gBloodSpawn;
    public override void MakeSoundAndUI()
    {
        base.MakeSoundAndUI();
        Instantiate(greenBlood, gBloodSpawn.position, Quaternion.identity);
    }
}
