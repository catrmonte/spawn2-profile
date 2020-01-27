using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    // Create temporary NPCs
    private Wizard m_Wizard;
    private Farmer m_Farmer;
    private Dog m_Dog;

    public void SpawnVillagers()
    {
        // Call the factory's GetNPC and cast that iCopyable to each NPC type
        m_Wizard = (Wizard)m_Factory.GetNPC(NPCType.Wizard);
        m_Farmer = (Farmer)m_Factory.GetNPC(NPCType.Farmer);
        m_Dog = (Dog)m_Factory.GetNPC(NPCType.Dog);

        // Have those NPCs speak
        m_Wizard.Speak();
        m_Farmer.Speak();
        m_Dog.Speak();
        
    }
}
