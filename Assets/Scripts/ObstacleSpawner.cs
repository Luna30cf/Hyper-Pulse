using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // Prefab de l'obstacle (triangle)
    public float spawnInterval = 2f; // Temps initial entre les apparitions des obstacles
    public float spawnHeight = 2f; // Hauteur maximale des obstacles
    public Transform spawnPoint; // Position de départ des obstacles

    private float timeElapsed = 0f; // Temps écoulé depuis le début du jeu
    public float difficultyIncreaseRate = 10f; // Temps en secondes pour augmenter la difficulté
    public float minSpawnInterval = 0.5f; // Intervalle minimum entre deux spawns
    private float currentSpawnInterval; // Intervalle actuel entre les spawns

    void Start()
    {
        // Initialisation de l'intervalle de spawn
        currentSpawnInterval = spawnInterval;

        // Démarrage du spawn répétitif
        InvokeRepeating("SpawnObstacle", 1f, currentSpawnInterval);
    }

    void Update()
    {
        // Augmenter la difficulté au fil du temps
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= difficultyIncreaseRate && currentSpawnInterval > minSpawnInterval)
        {
            // Réduire l'intervalle de spawn pour augmenter la difficulté
            currentSpawnInterval -= 0.1f;
            timeElapsed = 0f;

            // Met à jour l'invocation répétée avec le nouvel intervalle
            CancelInvoke("SpawnObstacle");
            InvokeRepeating("SpawnObstacle", 0f, currentSpawnInterval);
        }
    }

    void SpawnObstacle()
    {
        // Position aléatoire pour l'obstacle (en Y uniquement)
        float randomY = Random.Range(-spawnHeight, spawnHeight);
        Vector3 spawnPosition = new Vector3(spawnPoint.position.x, randomY, 0);

        // Créer un nouvel obstacle
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
