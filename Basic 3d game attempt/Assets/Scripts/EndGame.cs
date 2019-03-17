using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
