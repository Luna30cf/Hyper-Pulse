using UnityEngine;

public class GroundMover : MonoBehaviour
{
    public float speed = 5f;
    public float width = 10f; // Largeur de la plateforme

    void Update()
    {
        // Déplace le sol vers la gauche
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Lorsque le sol sort de l'écran (en fonction de la largeur de l'écran)
        if (transform.position.x < -width)
        {
            // Réinitialise la position à droite pour créer un effet infini
            transform.position = new Vector3(width, transform.position.y, transform.position.z);
        }
    }
}

