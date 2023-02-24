using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * This is a class to hold the functionality for the UI elements.
 */

public sealed class UI : MonoBehaviour
{
    /*
     * We made this class to be a singleton class to use through multiple scenes,
     * even though it wasn't required. We decided to keep it as it is,
     * since it's working.
     */
    private static readonly UI ourSingleton = new UI();

    public static UI GetInstance()
    {
        return ourSingleton;
    }

    // Updates the timer on to the UI.
    public void UpdateTime(Text timerText, string minutes, string seconds)
    {
        timerText.text = "Time " + minutes + ":" + seconds;
    }

    // Updates heart pictures in canvas to corresponding life total.
    public void UpdateLife(int life, GameObject[] hearts)
    {
        if (life == 0)
        {
            hearts[0].gameObject.SetActive(false);
            hearts[1].gameObject.SetActive(false);
            hearts[2].gameObject.SetActive(false);
            hearts[3].gameObject.SetActive(false);
            hearts[4].gameObject.SetActive(false);
            hearts[5].gameObject.SetActive(false);
            hearts[6].gameObject.SetActive(false);
            hearts[7].gameObject.SetActive(false);
            hearts[8].gameObject.SetActive(false);
            hearts[9].gameObject.SetActive(false);
        }
        else if (life == 1)
        {
            hearts[0].gameObject.SetActive(true);
            hearts[1].gameObject.SetActive(false);
            hearts[2].gameObject.SetActive(false);
            hearts[3].gameObject.SetActive(false);
            hearts[4].gameObject.SetActive(false);
            hearts[5].gameObject.SetActive(false);
            hearts[6].gameObject.SetActive(false);
            hearts[7].gameObject.SetActive(false);
            hearts[8].gameObject.SetActive(false);
            hearts[9].gameObject.SetActive(false);
        }
        else if (life == 2)
        {
            hearts[0].gameObject.SetActive(true);
            hearts[1].gameObject.SetActive(true);
            hearts[2].gameObject.SetActive(false);
            hearts[3].gameObject.SetActive(false);
            hearts[4].gameObject.SetActive(false);
            hearts[5].gameObject.SetActive(false);
            hearts[6].gameObject.SetActive(false);
            hearts[7].gameObject.SetActive(false);
            hearts[8].gameObject.SetActive(false);
            hearts[9].gameObject.SetActive(false);
        }
        else if (life == 3)
        {
            hearts[0].gameObject.SetActive(true);
            hearts[1].gameObject.SetActive(true);
            hearts[2].gameObject.SetActive(true);
            hearts[3].gameObject.SetActive(false);
            hearts[4].gameObject.SetActive(false);
            hearts[5].gameObject.SetActive(false);
            hearts[6].gameObject.SetActive(false);
            hearts[7].gameObject.SetActive(false);
            hearts[8].gameObject.SetActive(false);
            hearts[9].gameObject.SetActive(false);
        }
        else if (life == 4)
        {
            hearts[0].gameObject.SetActive(true);
            hearts[1].gameObject.SetActive(true);
            hearts[2].gameObject.SetActive(true);
            hearts[3].gameObject.SetActive(true);
            hearts[4].gameObject.SetActive(false);
            hearts[5].gameObject.SetActive(false);
            hearts[6].gameObject.SetActive(false);
            hearts[7].gameObject.SetActive(false);
            hearts[8].gameObject.SetActive(false);
            hearts[9].gameObject.SetActive(false);
        }
        else if (life == 5)
        {
            hearts[0].gameObject.SetActive(true);
            hearts[1].gameObject.SetActive(true);
            hearts[2].gameObject.SetActive(true);
            hearts[3].gameObject.SetActive(true);
            hearts[4].gameObject.SetActive(true);
            hearts[5].gameObject.SetActive(false);
            hearts[6].gameObject.SetActive(false);
            hearts[7].gameObject.SetActive(false);
            hearts[8].gameObject.SetActive(false);
            hearts[9].gameObject.SetActive(false);
        }
        else if (life == 6)
        {
            hearts[0].gameObject.SetActive(true);
            hearts[1].gameObject.SetActive(true);
            hearts[2].gameObject.SetActive(true);
            hearts[3].gameObject.SetActive(true);
            hearts[4].gameObject.SetActive(true);
            hearts[5].gameObject.SetActive(true);
            hearts[6].gameObject.SetActive(false);
            hearts[7].gameObject.SetActive(false);
            hearts[8].gameObject.SetActive(false);
            hearts[9].gameObject.SetActive(false);
        }
        else if (life == 7)
        {
            hearts[0].gameObject.SetActive(true);
            hearts[1].gameObject.SetActive(true);
            hearts[2].gameObject.SetActive(true);
            hearts[3].gameObject.SetActive(true);
            hearts[4].gameObject.SetActive(true);
            hearts[5].gameObject.SetActive(true);
            hearts[6].gameObject.SetActive(true);
            hearts[7].gameObject.SetActive(false);
            hearts[8].gameObject.SetActive(false);
            hearts[9].gameObject.SetActive(false);
        }
        else if (life == 8)
        {
            hearts[0].gameObject.SetActive(true);
            hearts[1].gameObject.SetActive(true);
            hearts[2].gameObject.SetActive(true);
            hearts[3].gameObject.SetActive(true);
            hearts[4].gameObject.SetActive(true);
            hearts[5].gameObject.SetActive(true);
            hearts[6].gameObject.SetActive(true);
            hearts[7].gameObject.SetActive(true);
            hearts[8].gameObject.SetActive(false);
            hearts[9].gameObject.SetActive(false);
        }
        else if (life == 9)
        {
            hearts[0].gameObject.SetActive(true);
            hearts[1].gameObject.SetActive(true);
            hearts[2].gameObject.SetActive(true);
            hearts[3].gameObject.SetActive(true);
            hearts[4].gameObject.SetActive(true);
            hearts[5].gameObject.SetActive(true);
            hearts[6].gameObject.SetActive(true);
            hearts[7].gameObject.SetActive(true);
            hearts[8].gameObject.SetActive(true);
            hearts[9].gameObject.SetActive(false);
        }
        else if (life == 10)
        {
            hearts[0].gameObject.SetActive(true);
            hearts[1].gameObject.SetActive(true);
            hearts[2].gameObject.SetActive(true);
            hearts[3].gameObject.SetActive(true);
            hearts[4].gameObject.SetActive(true);
            hearts[5].gameObject.SetActive(true);
            hearts[6].gameObject.SetActive(true);
            hearts[7].gameObject.SetActive(true);
            hearts[8].gameObject.SetActive(true);
            hearts[9].gameObject.SetActive(true);
        }
    }

    // button onClick() function in Deathscreens.
    public void DeathScreenButton1()
    {
        SceneManager.LoadScene("Level1");
    }

    // button onClick() function in Deathscreens.
    public void DeathScreenButton2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void DeathScreenButton3()
    {
        SceneManager.LoadScene("Level1HC");
    }
}
