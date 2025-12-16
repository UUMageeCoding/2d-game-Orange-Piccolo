using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollectableDrop : MonoBehaviour
{
    [SerializeField]
    private float _chanceOfCollectableDrop;

    private CollectableSpawner _collectableSpawner;

    private void Awake()
    {
        // Finds the Collectable Spawner prefab to allow the enemy to drop collectables
        _collectableSpawner = FindFirstObjectByType<CollectableSpawner>();
    }

    // Determines the odds of the enemy dropping a Collectable upon death
    public void RandomlyDropCollectable()
    {
        float random = Random.Range(0f, 1f);

        if (_chanceOfCollectableDrop >= random)
        {
            _collectableSpawner.SpawnCollectable(transform.position);
        }
    }
}
