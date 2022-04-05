using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Gravity : MonoBehaviour
{
    
    private void Start()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
    }

    public void TurnOnGravity()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

    public void ResetGravity()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        transform.Translate(0, 10, 0, Space.World);
    }

}