using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // R�f�rence au joueur
    public float offsetX = 7f; // D�calage horizontal

    void Update()
    {
        if (player != null)
        {
            // Suivre la position X du joueur avec un d�calage
            transform.position = new Vector3(player.position.x + offsetX, transform.position.y, transform.position.z);
        }
    }
}
