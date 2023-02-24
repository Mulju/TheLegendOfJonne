using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * This class defines what datatypes the characters have.
 * A character can have a name and different dialogue boxes, which store the sentences.
 * We are using [System.Serializable] to modify these fields through Unity.
 */
[System.Serializable]
public class Dialogue
{
    
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;
    
}
