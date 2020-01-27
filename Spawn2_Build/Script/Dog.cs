using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour, INPC, iCopyable
{
    public void Speak()
    {
        Debug.Log("Woof, woof. Arf?");
    }

    // Copy function for iCopyable
    public iCopyable Copy()
    {
        // Actually instatiates the new Dog
        return Instantiate(this);
    }
}
