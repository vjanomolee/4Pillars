using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal                 // INHERITANCE 
{
    [Tooltip("Drag gameobject from the heirarchy w/particle system you want here")]
    public GameObject feathers;
    public string myText;

    public override void MakeSoundAndUI()                       // POLYMORPHISM
    {
        base.MakeSoundAndUI();// Run the base method         
        AbstractedMethod(); //and then do whatever else you want.
        ExplanationEncapsulation(); // enable the animated title and explanation overlay UI
    }
    public void AbstractedMethod()                               // ABSTRACTION
    {
        ParticleSystem ps = feathers.GetComponent<ParticleSystem>();
        ps.Play();
        SpeechBubbleTMP.SetText(myText);    // ENCAPSULATION
    }   // SpeechBubbleTMP is Encapsulated from base class
}
