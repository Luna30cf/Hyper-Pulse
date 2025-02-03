using UnityEngine;
using System.Collections.Generic;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // Prefab de l'obstacle
    public float spawnInterval = 2f; // Temps entre chaque apparition des obstacles
    public float spawnHeightOffset = -0.5f; // Décalage de la hauteur des obstacles par rapport à la plateforme (0.5 unités en dessous)
    public float difficultyIncreaseRate = 10f; // Temps en secondes pour augmenter la difficulté
    public float minSpawnInterval = 0.5f; // Intervalle minimum entre deux spawns
    private float currentSpawnInterval; // Intervalle actuel entre les spawns
    private float timeElapsed = 0f; // Temps écoulé depuis le début du jeu

    private List<GameObject> groundObjects = new List<GameObject>(); // Liste des objets avec le tag "Ground"

    void Start()
    {
        // Initialisation de l'intervalle de spawn
        currentSpawnInterval = spawnInterval;

        // Trouver tous les objets avec le tag "Ground" (plateformes et sol)
        groundObjects.AddRange(GameObject.FindGameObjectsWithTag("Ground"));

        if (groundObjects.Count == 0)
        {
            Debug.LogError("Aucun objet trouvé avec le tag 'Ground'. Vérifie tes objets.");
        }

        // Démarrage du spawn continu
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
        if (groundObjects.Count == 0)
        {
            // Si aucune plateforme/sol n'est trouvé, arrête le spawn
            Debug.LogWarning("Aucun objet trouvé pour spawn des obstacles");
            return;
        }

        // Sélectionner un objet aléatoire (plateforme ou sol)
        GameObject selectedGround = groundObjects[Random.Range(0, groundObjects.Count)];

        // Vérifier que l'objet est actif
        if (selectedGround == null || !selectedGround.activeInHierarchy)
        {
            Debug.LogWarning("Objet invalide ou désactivé, recherche une autre plateforme...");
            return;
        }

        // Récupérer la position de l'objet
        Vector3 groundPosition = selectedGround.transform.position;

        // Récupérer la largeur de l'objet (si tu utilises un BoxCollider2D pour les plateformes et le sol)
        float groundWidth = selectedGround.GetComponent<Collider2D>().bounds.size.x;

        // Générer une position aléatoire sur l'objet
        float randomX = Random.Range(groundPosition.x - groundWidth / 2, groundPosition.x + groundWidth / 2);
        float spawnY = groundPosition.y + spawnHeightOffset; // L'offset pour que l'obstacle soit en dessous de l'objet

        // Créer un nouvel obstacle à la position calculée
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
