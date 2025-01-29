using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float speed = 5f; // Vitesse de déplacement

    void Update()
    {
        // Déplacement vers la gauche
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Détruire l'obstacle hors de l'écran
        if (transform.position.x < -10f) // Ajustez la valeur selon la largeur de votre scène
        {
            Destroy(gameObject);
        }
    }
}
