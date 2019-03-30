using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;
    private float RESTART_DELAY = 2;

    public void GameOver()
    {
        if(!gameOver) {
            gameOver = true;
            Invoke("Restart", RESTART_DELAY);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Complete!");
    }
}
