using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Manager : MonoBehaviour
{
    [SerializeField]
    public static int matrixSize =2;
    [SerializeField]
    private float titlesize = 0;
    public static GameObject[,] matrixGame;


    void Start()
    {
        matrixGame = new GameObject[matrixSize, matrixSize];
        Generate();
    }
 
    private void Generate()
    {
        Camera.main.orthographicSize = matrixSize;
        Vector2 pos = Camera.main.ScreenToWorldPoint(new Vector2(0, Camera.main.pixelHeight));
        GameObject referens = (GameObject)Instantiate(Resources.Load("2"));
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                GameObject title = (GameObject)Instantiate(referens, transform);
                title.name = $"{row} {col}";
                title.transform.position = pos + new Vector2(col * titlesize + titlesize/2f, row * -titlesize - titlesize/2f);
                title.tag = "0";
                matrixGame[row, col] = title;
            }    
        }
        Destroy(referens);

        int numberMix;
        int x, y;
        System.Random rand = new System.Random();
        //������������� 
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
