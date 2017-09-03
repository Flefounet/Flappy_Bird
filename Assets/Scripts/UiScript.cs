using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }

    //Your scene name
    public void Replay()
    {
        SceneManager.LoadScene("Scenes");
    }
}

