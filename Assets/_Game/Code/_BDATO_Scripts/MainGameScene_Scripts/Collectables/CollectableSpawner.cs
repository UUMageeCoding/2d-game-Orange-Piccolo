using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    [SerializeField]
    // Allows choice of what items to spawn from the Inspector
    private List<GameObject> _collectablePrefabs;

    // Chooses a random collectable to spawn
    public void SpawnCollectable(Vector2 position)
    {
        int index = Random.Range(0, _collectablePrefabs.Count);
        var selectedCollectable = _collectablePrefabs[index];

        Instantiate(selectedCollectable, position, Quaternion.identity);
    }
}
