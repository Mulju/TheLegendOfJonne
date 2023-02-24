using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    /*
     * This class lets the gameobject in Unity hold the data for the characters.
     * The mechanics for this character are implemented in the DialogueManager class.
     */
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
