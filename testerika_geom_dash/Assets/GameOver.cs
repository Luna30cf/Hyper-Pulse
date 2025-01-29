using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            // stop ler jeu
            Time.timeScale = 0;
        }
    }
}
