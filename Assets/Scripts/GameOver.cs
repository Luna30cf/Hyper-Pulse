using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            // stop le jeu
            Time.timeScale = 0;
            SceneManager.LoadScence("GameOver")
        }
    }
}
