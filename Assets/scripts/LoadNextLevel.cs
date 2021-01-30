using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNextLevel : MonoBehaviour
{
    public GameManager manager;

    public void LoadNextL()
    {
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCount) manager.exitGame();
        else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
