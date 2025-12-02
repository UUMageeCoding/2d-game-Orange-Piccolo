using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneSwitching : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BreakRoomSceneChange")
        {
            SceneManager.LoadScene(0);
        }
    }
}
