using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over! Redirection vers la sc�ne GameOver.");
            SceneManager.LoadScene("GameOver"); // Charge la sc�ne GameOver
        }
    }
}
