using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab; // Prefab de la plateforme
    public float spawnInterval = 3f; // Intervalle entre chaque apparition de plateforme
    public float minY = -4f; // Hauteur � laquelle les plateformes vont appara�tre
    public float maxY = -2f; 
    public float minX = 30f; // Position X minimale
    public float maxX = 40f;  // Position X maximale
    public float platformWidth = 3f; // Largeur de la plateforme pour �viter qu'elles ne soient trop proches

    private float timeElapsed = 0f; // Temps �coul� depuis le d�but du jeu
    public float difficultyIncreaseRate = 10f; // Temps pour augmenter la difficult�
    public float minSpawnInterval = 1f; // Intervalle minimum entre deux spawns
    private float currentSpawnInterval; // Intervalle actuel entre les spawns

    private void Start()
    {
        // Initialisation de l'intervalle de spawn
        currentSpawnInterval = spawnInterval;

        // D�marrage du spawn r�p�titif
        InvokeRepeating("SpawnPlatform", 1f, currentSpawnInterval);
    }

    private void Update()
    {
        // Augmenter la difficult� au fil du temps
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= difficultyIncreaseRate && currentSpawnInterval > minSpawnInterval)
        {
            // R�duire l'intervalle de spawn pour augmenter la difficult�
            currentSpawnInterval -= 0.1f;
            timeElapsed = 0f;

            // Met � jour l'invocation r�p�t�e avec le nouvel intervalle
            CancelInvoke("SpawnPlatform");
            InvokeRepeating("SpawnPlatform", 0f, currentSpawnInterval);
        }
    }

    private void SpawnPlatform()
    {
        // Position X al�atoire pour la plateforme
        float randomX = Random.Range(minX, maxX);

        // Position Y al�atoire pour la plateforme, en fonction de la hauteur
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

        // Cr�er une nouvelle plateforme
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }
}

