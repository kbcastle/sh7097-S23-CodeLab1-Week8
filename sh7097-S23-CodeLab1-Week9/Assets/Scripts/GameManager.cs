using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public List<ScriptableObject> cardList = new List<ScriptableObject>();
    public Sprite card1;
    public Sprite card2;
    public Sprite card3; 
    int listIndex;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (card1 = null)
            {
                listIndex = Random.Range(0, 5);
                card1 = cardList[listIndex].GetComponent<Sprite>();
                cardList.RemoveAt(listIndex);
            }
            else
            {
                if (card2 = null)
                {
                    listIndex = Random.Range(0, 4);
                    card2 = cardList[listIndex].GetComponent<Sprite>();
                    cardList.RemoveAt(listIndex);
                }
                else
                {
                    listIndex = Random.Range(0, 3);
                    card3 = cardList[listIndex].GetComponent<Sprite>();
                    cardList.Clear();
                    cardList.Add(CardsScriptableObjects);
                    
                }
            }
        }
    }
}