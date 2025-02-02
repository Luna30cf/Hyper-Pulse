using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float speed = 5f; // Vitesse de d�placement

    void Update()
    {
        // D�placement vers la gauche
        transform.position += Vector3.left * speed * Time.deltaTime;

        // D�truire l'obstacle hors de l'�cran
        if (transform.position.x < -10f) // Ajustez la valeur selon la largeur de votre sc�ne
        {
            Destroy(gameObject);
        }
    }
}
