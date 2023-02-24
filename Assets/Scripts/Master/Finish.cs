using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private AudioSource finishSound;

    // Triggers NewLevel() methdod after 4 seconds when player collides with the NextLevel object.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            finishSound.Play();
            Invoke("NewLevel", 4f);
        }
    }

    // Loads the next scene and resets player position to the start of the new level.
    public void NewLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerManager.lastCheckPointPos = new Vector2(0, 0);
    }
}
