using UnityEngine;

public class GroundMover : MonoBehaviour
{
    public float speed = 5f;
    public float width = 10f; // Largeur de la plateforme

    void Update()
    {
        // D�place le sol vers la gauche
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Lorsque le sol sort de l'�cran (en fonction de la largeur de l'�cran)
        if (transform.position.x < -width)
        {
            // R�initialise la position � droite pour cr�er un effet infini
            transform.position = new Vector3(width, transform.position.y, transform.position.z);
        }
    }
}

