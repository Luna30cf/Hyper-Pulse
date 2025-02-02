using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle")) // Vérifie si l'objet touché a le tag "Obstacle"
        {
            Debug.Log("Game Over! Redirection vers la scène GameOver.");
            SceneManager.LoadScene("GameOver"); // Charge la scène GameOver
        }
    }
}
