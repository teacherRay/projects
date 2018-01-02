using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: "+ name);
        SceneManager.LoadScene("Game");

    }

    public void ReturnToStartScreen()
    {
        Debug.Log("Trying to load Start Level");
        SceneManager.LoadScene("Start");
    }


    public void QuitGame()
    {
        Debug.Log("Player Quit");
        Application.Quit();
    }

}
