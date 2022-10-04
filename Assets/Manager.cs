using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    public static int matrixSize = 4;
    [SerializeField]
    private float titlesize = 1;

    public static GameObject[,] matrixGame;

    // Start is called before the first frame update
    void Start()
    {
        matrixGame = new GameObject[matrixSize, matrixSize];
        Generate();
    }

    private void Generate()
    {
        GameObject referens = (GameObject)Instantiate(Resources.Load("2"));

        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                GameObject title = (GameObject)Instantiate(referens, transform);
                title.name = $"{row} {col}";
                title.transform.position = new Vector2(col * titlesize, row * -titlesize);
                title.tag = "0";
                matrixGame[row, col] = title;
            }
            
        }

        Destroy(referens);
        float gridW = matrixSize * titlesize;
        //float gridH = matrixSize * titlesize;
        //transform.position = new Vector2(-gridW / 2 + titlesize / 2, gridW / 2 - titlesize / 2) ;
        
        /*
        var sz = 0;
        if (cols > rows)
             sz = cols;
        else
             sz = rows;
        Camera.main.orthographicSize = sz;
        Vector2 coor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        */
        //Debug.Log(coor);
       // transform.position = coor;
    }
  
}
