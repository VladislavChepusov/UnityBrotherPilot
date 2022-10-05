using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(1);
   
    }

}
