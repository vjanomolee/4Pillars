using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : Animal  // INHERITANCE
{
    [Tooltip("Drag gameobject from the heirarchy w/particle system you want here")]
    public GameObject greenBlood;
    public string myText;

    public override void MakeSoundAndUI()                       // POLYMORPHISM
    {
        base.MakeSoundAndUI();// Run the base method         
        abstractedMethod(); //and then do whatever else you want.
    }
    public void abstractedMethod()                               // ABSTRACTION
    {
        ParticleSystem ps = greenBlood.GetComponent<ParticleSystem>();
        ps.Play();
        SpeechBubbleTMP.SetText(myText);    // ENCAPSULATION
    }   // SpeechBubbleTMP is Encapsulated from base class
}