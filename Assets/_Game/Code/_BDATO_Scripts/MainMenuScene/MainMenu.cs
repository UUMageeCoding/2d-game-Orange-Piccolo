using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private SceneController _sceneController;
    public void Play()
    {
        _sceneController.LoadScene("Break_Room_Scene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
