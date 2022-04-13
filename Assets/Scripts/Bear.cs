using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Animal                                      // INHERITANCE
{
    [Tooltip("Drag gameobject from the heirarchy w/particle system you want here")]
    public GameObject redBlood;

    public override void MakeSoundAndUI()                       // POLYMORPHISM
    {
        base.MakeSoundAndUI();// Run the base method         
        AbstractedMethod(); //and then do whatever else you want.
        ExplanationInheritance(); // // enable the animated title and explanation overlay UI
    }
    public void AbstractedMethod ()                               // ABSTRACTION
    {
        ParticleSystem ps = redBlood.GetComponent<ParticleSystem>();
        ps.Play();
        SpeechBubbleTMP.SetText("My Bear script INHERITS many great things from my Animal parent class! " +
            "Like my healthbar, ability to take damage, and THIS Talk bubble! ROAR!");    // ENCAPSULATION
    }   // SpeechBubbleTMP is Encapsulated from base class
}