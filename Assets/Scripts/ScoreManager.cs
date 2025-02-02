using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Référence au texte du score
    private int score = 0;
    private float timeElapsed = 0f; // Accumulateur de temps pour gérer l'incrémentation

    void Start()
    {
        score = 0;
        UpdateScoreUI();
    }

    void Update()
    {
        // Accumuler le temps et ajouter 1 point par seconde
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= 1f) // Toutes les 1 seconde
        {
            score += 1; // Ajoute 1 au score
            timeElapsed = 0f; // Réinitialiser le compteur
            UpdateScoreUI();
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.LogWarning("⚠️ ScoreText n'est pas assigné dans l'inspecteur !");
        }
    }
}
