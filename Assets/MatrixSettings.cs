using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class MatrixSettings : MonoBehaviour
{

    [SerializeField]
    private TMP_Text texting;

    private int local_count;
    private void Start()
    {
        local_count = Manager.matrixSize;
        texting.text = $"{local_count}";
    }


    public void Up()
    {
        if (local_count < 30)
        {
            local_count++;
            texting.text = $"{local_count}";
        } 
    }


    public void Down()
    {
        if (local_count > 2)
        {
            local_count--;
            texting.text = $"{local_count}";
        }
    }


    public void Apply()
    {
        Manager.matrixSize = local_count;
        SceneManager.LoadScene(1);
    }


    private void Update()
    {
        if (Input.GetKey("escape"))
            SceneManager.LoadScene(0);
    }
}
