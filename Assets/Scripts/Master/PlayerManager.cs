using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool timer = false;
    public static Vector2 lastCheckPointPos = new Vector2(0, 0);

    private void Awake()
    {
        /* When lives reach 0 in PlayerLife Class, bool gameOver changes to true.
           Changes Player location from last Checkpoint to the start of the scene and sets gameOver back to false. */
        if (gameOver == true)
        {
            lastCheckPointPos = new Vector2(0, 0);
            GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
            gameOver = false;
            timer = true;
        }
        // When scene reloads, returns Player to last Checkpoint
        else
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
        }
    }
}

