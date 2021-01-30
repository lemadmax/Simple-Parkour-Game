using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;
    public float restartDelay = 2.0f;
    public GameObject completeLevelUI;

    public void levelWon()
    {
        completeLevelUI.SetActive(true);

    }

    public void endGame()
    {
        if(!gameEnded)
        {
            gameEnded = true;
            Invoke("startGame", restartDelay);
        }
    }

    public void exitGame()
    {
        Application.Quit();
    }

    void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
