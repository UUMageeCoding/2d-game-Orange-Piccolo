using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeBehaviour : MonoBehaviour, ICollectableBehaviour
{
    [SerializeField]
    private float _healthAmount;
    public void OnCollected(GameObject Player)
    {
        Player.GetComponent<HealthController>().AddHealth(_healthAmount);
    }
}
