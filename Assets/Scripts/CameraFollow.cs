using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Référence au joueur
    public float offsetX = 8.5f; // Décalage horizontal

    void Update()
    {
        if (player != null)
        {
            // Suivre la position X du joueur avec un décalage
            transform.position = new Vector3(player.position.x + offsetX, transform.position.y, transform.position.z);
        }
    }
}
