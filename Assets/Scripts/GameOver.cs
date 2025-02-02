using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle")) // V�rifie si l'objet touch� a le tag "Obstacle"
        {
            Debug.Log("Game Over! Redirection vers la sc�ne GameOver.");
            SceneManager.LoadScene("GameOver"); // Charge la sc�ne GameOver
        }
    }
}
