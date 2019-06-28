using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    bool gameOver = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUIl;
    public void CompleteLevel() {
        completeLevelUIl.SetActive(true);
    }

    public void EndGame() {
        if (!gameOver) {
            gameOver = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
