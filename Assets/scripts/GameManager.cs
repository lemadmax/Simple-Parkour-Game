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
            Invoke("restartGame", restartDelay);
        }
    }

    public void loadFirstScene()
    {
        SceneManager.LoadScene(0);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
