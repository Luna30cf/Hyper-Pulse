using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // Prefab de l'obstacle (triangle)
    public float spawnInterval = 2f; // Temps initial entre les apparitions des obstacles
    public float spawnHeight = 2f; // Hauteur maximale des obstacles
    public Transform spawnPoint; // Position de d�part des obstacles

    private float timeElapsed = 0f; // Temps �coul� depuis le d�but du jeu
    public float difficultyIncreaseRate = 10f; // Temps en secondes pour augmenter la difficult�
    public float minSpawnInterval = 0.5f; // Intervalle minimum entre deux spawns
    private float currentSpawnInterval; // Intervalle actuel entre les spawns

    void Start()
    {
        // Initialisation de l'intervalle de spawn
        currentSpawnInterval = spawnInterval;

        // D�marrage du spawn r�p�titif
        InvokeRepeating("SpawnObstacle", 1f, currentSpawnInterval);
    }

    void Update()
    {
        // Augmenter la difficult� au fil du temps
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= difficultyIncreaseRate && currentSpawnInterval > minSpawnInterval)
        {
            // R�duire l'intervalle de spawn pour augmenter la difficult�
            currentSpawnInterval -= 0.1f;
            timeElapsed = 0f;

            // Met � jour l'invocation r�p�t�e avec le nouvel intervalle
            CancelInvoke("SpawnObstacle");
            InvokeRepeating("SpawnObstacle", 0f, currentSpawnInterval);
        }
    }

    void SpawnObstacle()
    {
        // Position al�atoire pour l'obstacle (en Y uniquement)
        float randomY = Random.Range(-spawnHeight, spawnHeight);
        Vector3 spawnPosition = new Vector3(spawnPoint.position.x, randomY, 0);

        // Cr�er un nouvel obstacle
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
