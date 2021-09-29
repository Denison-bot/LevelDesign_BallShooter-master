using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    public int nextScene;
    private int currentScene;
    
    
    public void LoadNextlevel()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        
        if (nextScene <= 5)
        {
            SceneManager.LoadScene(nextScene);                       
        }

        else if (nextScene >= 6)
        {
            Debug.Log("All levels complete!");
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();        
    }
}



