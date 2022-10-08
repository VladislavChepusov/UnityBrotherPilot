using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void _Starting()
    {
        //Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void _Exit()
    {
        Application.Quit();
    }


    public void _Settings()
    {
        SceneManager.LoadScene(2);
    }
}
