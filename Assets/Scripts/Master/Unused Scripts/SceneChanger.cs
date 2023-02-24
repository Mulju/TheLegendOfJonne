using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    
    private List<string> sceneHistory = new List<string>();
    // private bool returnValue = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadScene(string newScene)
    {
        sceneHistory.Add(newScene);
        SceneManager.LoadScene(newScene);
    }

    public bool PreviousScene()
    {
        bool returnValue = false;
        if (sceneHistory.Count >= 1)
        {
            returnValue = true;
            sceneHistory.RemoveAt(sceneHistory.Count - 1);
            SceneManager.LoadScene(sceneHistory[sceneHistory.Count - 1]);
        }

        return returnValue;
    }
    
}
