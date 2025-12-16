using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeBehaviour : MonoBehaviour, ICollectableBehaviour
{
    [SerializeField]
    // Allows assignment of health restored by Coffee item in Inspector
    private float _healthAmount;
    public void OnCollected(GameObject Player)
    {
        Player.GetComponent<HealthController>().AddHealth(_healthAmount);
    }
}
