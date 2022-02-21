using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] runners;
    List<RankSystem> sortArray = new List<RankSystem>();
    public Text[] rankTexts;
    // Start is called before the first frame update
   
    void Start()
    {
        for(int i = 0; i < runners.Length; i++)
        {
            sortArray.Add(runners[i].GetComponent<RankSystem>());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateRank();
        RankWriter();
        rankTexts[0].text = sortArray[10].name.ToString();

    }

    private void RankWriter()
    {
        rankTexts[0].text = sortArray[10].name.ToString();
        rankTexts[1].text = sortArray[9].name.ToString();
        rankTexts[2].text = sortArray[8].name.ToString();
        rankTexts[3].text = sortArray[7].name.ToString();
        rankTexts[4].text = sortArray[6].name.ToString();
        rankTexts[5].text = sortArray[5].name.ToString();
        rankTexts[6].text = sortArray[4].name.ToString();
        rankTexts[7].text = sortArray[3].name.ToString();
        rankTexts[8].text = sortArray[2].name.ToString();
        rankTexts[9].text = sortArray[1].name.ToString();
        rankTexts[10].text = sortArray[0].name.ToString();

    }

    private void CalculateRank()
    {
        sortArray = sortArray.OrderBy(x => x.counter).ToList();
        sortArray[0].rank = 11;
        sortArray[1].rank = 10;
        sortArray[2].rank = 9;
        sortArray[3].rank = 8;
        sortArray[4].rank = 7;
        sortArray[5].rank = 6;
        sortArray[6].rank = 5;
        sortArray[7].rank = 4;
        sortArray[8].rank = 3;
        sortArray[9].rank = 2;
        sortArray[10].rank = 1;
        
    }
}
