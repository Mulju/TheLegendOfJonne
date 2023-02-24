using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameMusicPlayer : MonoBehaviour
{
    // From https://answers.unity.com/questions/1260393/make-music-continue-playing-through-scenes.html

    private static GameMusicPlayer instance = null;
    public static GameMusicPlayer Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        // Saves music object and and continues play over scene reload.
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // turns off the music during the DeathScreen.
    private void Update()
    {
        if (SceneManager.GetSceneByName("DeathScreen").isLoaded || SceneManager.GetSceneByName("DeathScreen2").isLoaded || SceneManager.GetSceneByName("DeathScreenHC").isLoaded || SceneManager.GetSceneByName("MainMenu").isLoaded)
        {
            Destroy(this.gameObject);
        }
    }
}