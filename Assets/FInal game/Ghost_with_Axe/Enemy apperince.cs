using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject spawnedEnemy;

    void Start()
    {
        // Spawn the enemy
        spawnedEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);

        // Start the coroutine to destroy after 5 seconds
        StartCoroutine(RemoveEnemyAfterDelay(5f));
    }

    System.Collections.IEnumerator RemoveEnemyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(spawnedEnemy);
    }
}

