using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BDATOGameManager : MonoBehaviour
{
    [SerializeField]
    private float _timeToWaitBeforeExit;
    
    public void OnPlayerDied()
    {
        Invoke(nameof(EndGame), _timeToWaitBeforeExit);
    }

    private void EndGame()
    {
        SceneManager.LoadScene(0);
    }
}
