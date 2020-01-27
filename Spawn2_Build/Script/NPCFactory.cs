using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    private Wizard m_Wizard;
    private Farmer m_Farmer;
    private Dog m_Dog;

    public void Start()
    {
        // Establishes new NPC objects and gets the prefabs from the Resources folder  
        GameObject wiz_obj = Instantiate(Resources.Load("Wizard")) as GameObject;
        m_Wizard = wiz_obj.GetComponent<Wizard>();

        GameObject farm_obj = Instantiate(Resources.Load("Farmer")) as GameObject;
        m_Farmer = farm_obj.GetComponent<Farmer>();

        GameObject dog_obj = Instantiate(Resources.Load("Dog")) as GameObject;
        m_Dog = dog_obj.GetComponent<Dog>();
    }

    public iCopyable GetNPC(NPCType type)
    {
        // for each type of NPC, create an iCopyable of that NPC and calls the iCopyable Copy function
        // returns an iCopyable
        switch (type)
        {
            case NPCType.Wizard:
                iCopyable wizard = m_Wizard.Copy();
                return wizard;
            case NPCType.Farmer:
                iCopyable farmer = m_Farmer.Copy();
                return farmer;
            case NPCType.Dog:
                iCopyable dog = m_Dog.Copy();
                return dog;
        }

        return null;
    }
}
