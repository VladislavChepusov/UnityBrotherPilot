using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    //[SerializeField]
    public static int matrixSize = 2;
    [SerializeField]
    private float titlesize = 0;
    public static GameObject[,] matrixGame;


    void Start()
    {
        matrixGame = new GameObject[matrixSize, matrixSize];
        Generate();
    }

    void Update()
    {
        if (Input.GetKey("escape")) 
            SceneManager.LoadScene(0);
    }

    private void Generate()
    {
        Camera.main.orthographicSize = matrixSize;

        Vector2 pos = Camera.main.ScreenToWorldPoint(new Vector2(0, Camera.main.pixelHeight));
        Camera cam = Camera.main;
        Vector2 pos1 = new Vector2(cam.orthographicSize, 0);

        GameObject referens = (GameObject)Instantiate(Resources.Load("2"));


        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                GameObject title = (GameObject)Instantiate(referens, transform);
                title.name = $"{row} {col}";
                title.transform.position = pos + pos1 +  new Vector2(col * titlesize + titlesize/2f, row * -titlesize - titlesize/2f) ;
                //title.transform.position = new Vector2(col * titlesize , row * -titlesize );


                title.tag = "0";
                matrixGame[row, col] = title;
            }    
        }
        Destroy(referens);

        int numberMix;
        int x, y;
        System.Random rand = new System.Random();
        //Пермеешивание 
        do
        {
            numberMix = rand.Next(matrixSize, matrixSize + 20);
            for (int num = 0; num < numberMix; num++)
            {
                x = rand.Next(0, matrixSize);
                for (int j = 0; j < matrixSize; ++j)
                    checkMouse.revers(matrixGame[x, j]);
                y = rand.Next(0, matrixSize);
                for (int i = 0; i < matrixSize; ++i)
                    checkMouse.revers(matrixGame[i, y]);
                checkMouse.revers(matrixGame[x, y]);
            }
        } while (checkMouse.CheckWin());
    }
  
}
