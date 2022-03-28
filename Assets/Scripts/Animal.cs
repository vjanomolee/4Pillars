using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

	public string Name;



	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		//if OnMouseDown 
		// { MakeSounAndUI(); MakeMoveHurt(); MakeHeathHurt(); 
		// else 
	}
	
	public virtual void MakeSoundAndUI()
	{
		// show UI of that animals sound
		//play sound clip
	}

	public virtual void MakeMoveHurt()
    {
		// play hurt animation clip once
    }

	public virtual void MakeHealthHurt()
    {
		//// talk to health system and reduce health by 1
	}

	public virtual void ChillState()
    {
		// face the camera
		//play idle animation on loop

    }

}

