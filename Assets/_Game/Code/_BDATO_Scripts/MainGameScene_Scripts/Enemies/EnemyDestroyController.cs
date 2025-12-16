using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyController : MonoBehaviour
{
    public void DestroyEnemy(float delay)
    {
        // Puts a delay on the removal of the enemy game object to allow the death animation to play
        Destroy(gameObject, delay);
    }
}
