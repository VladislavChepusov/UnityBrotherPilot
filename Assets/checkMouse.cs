
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class checkMouse : MonoBehaviour,IPointerClickHandler
{
    //Переключение рычагов
    void revers(GameObject go)
    {
        if (go.tag == "0")
        {
            go.tag = "1";
            go.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/1");
        }
        else
        {
            go.tag = "0";
            go.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/2");
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject button = this.gameObject;
        /*
        if (button.GetComponent<SpriteRenderer>().sprite.name == "2")
            button.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/1");
        else
            button.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/2");
        */

        string[] strKoord = button.name.Split(' ');
        int x = Convert.ToInt32(strKoord[0]);
        int y = Convert.ToInt32(strKoord[1]);

        for (int j = 0; j < Manager.matrixSize; j++)
            revers(Manager.matrixGame[x, j]);
        for (int i = 0; i < Manager.matrixSize; i++)
            revers(Manager.matrixGame[i, y]);
        revers(Manager.matrixGame[x, y]);


        //Manager.matrixGame[1,1].GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/1"); ;

    }







   

    // Update is called once per frame
    void Update()
    {
        
    }
}
