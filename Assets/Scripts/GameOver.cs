using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over! Redirection vers la scène GameOver.");
            SceneManager.LoadScene("GameOver"); // Charge la sc�ne GameOver
        }
    }
}
