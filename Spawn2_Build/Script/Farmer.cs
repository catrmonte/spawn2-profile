using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour, INPC, iCopyable
{
    public void Speak()
    {
        Debug.Log("You reap what you sow.");
    }

    // Copy function for iCopyable
    public iCopyable Copy()
    {
        // Actually does the instantiation of the new Farmer
        return Instantiate(this);
    }
}
