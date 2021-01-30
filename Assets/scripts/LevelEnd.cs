using UnityEngine;

public class LevelEnd : MonoBehaviour
{

    public GameManager manager;

    private void OnTriggerEnter(Collider other)
    {
        manager.levelWon();
    }

}
