using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int scoreLast; 
    public TMP_Text textScore;
    public int score = 0; //score counter

    // Start is called before the first frame update
    void Start()
    {
        textScore.text = "Chickens collected: "+ score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreLast != score) // IF STATEMENT THAT CHECKS IF SCORE HAS CHANGED👈
        {
            textScore.text ="Chickens collected: "+ score.ToString();
        }
    }
}
