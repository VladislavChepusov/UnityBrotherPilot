
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class checkMouse : MonoBehaviour,IPointerClickHandler
{
   
    public static void revers(GameObject go)
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
        string[] strKoord = button.name.Split(' ');
        int x = Convert.ToInt32(strKoord[0]);
        int y = Convert.ToInt32(strKoord[1]);
        for (int j = 0; j < Manager.matrixSize; j++)
            revers(Manager.matrixGame[x, j]);
        for (int i = 0; i < Manager.matrixSize; i++)
            revers(Manager.matrixGame[i, y]);
        revers(Manager.matrixGame[x, y]);

        if (CheckWin())
        {
            Debug.Log("Ó ÍÀÑ ÏÎÁÅÄÈÒÅËÜ");
            Manager.matrixSize++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
      
       

    }

    // Ïðîâåðêà ïîáåäû
    public static bool CheckWin()
    {
        int up = 0;
        int down = 0;
        for (int i = 0; i < Manager.matrixSize; i++)
            for (int j = 0; j < Manager.matrixSize; j++)
            {
                if (Manager.matrixGame[i, j].tag == "0")
                    down++;
                else up++;
            }
        if (down == Manager.matrixSize * Manager.matrixSize || up == Manager.matrixSize * Manager.matrixSize)
            return true;
        return false;
    }







}
