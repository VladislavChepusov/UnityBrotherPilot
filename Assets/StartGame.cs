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

    public int xq = 0;

    public void _Settings()
    {

        Debug.Log($"Настройка еще не реализована {xq}");
        xq++;

       var cameras_trans_list1 = Resources.FindObjectsOfTypeAll(typeof(Camera)) as Camera[];

     Camera cam1 = GameObject.Find("fistCamera").GetComponent<Camera>();
      Camera cam2 = GameObject.Find("secondCamera").GetComponent<Camera>();
        if (xq == 0)
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }

        if (xq == 1)
        {
            cam1.enabled = false;
            cam2.enabled = true;

        }

        if (xq > 1)
        {
            xq = 0;
        }
    }
}
