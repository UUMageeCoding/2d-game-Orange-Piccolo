using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthbarUI : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image _healthbarForegroundImage;
    public void UpdateHealthbar(HealthController healthController)
    {
        _healthbarForegroundImage.fillAmount = healthController.RemainingHealthPercentage;
    }
}
