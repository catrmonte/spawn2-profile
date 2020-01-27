using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour, INPC, iCopyable
{
    public void Speak()
    {
        Debug.Log("The mysterious arts are my specialty.");
    }

    // Copy function for iCopyable
    public iCopyable Copy()
    {
        // Actually does the instantiation of the new Wizard
        return Instantiate(this);
    }
}
