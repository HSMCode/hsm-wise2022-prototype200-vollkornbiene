using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScoreManager : MonoBehaviour
{
    private string LevelToLoad;

    // for timer
    private float timer = 160f;
    private TMP_Text timerSeconds;
    private bool counting = true;

    // for score
    public float score;
    private float currentScore;
    private float winScore = 8f;
    private TMP_Text textScore;

    // for game over
    private GameObject gameOverCanvas;
    private GameObject loseText;
    private GameObject winText;

    private GameObject player;
    private GameObject stall;

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GameObject.Find("TimerText").GetComponent<TMP_Text>();
        textScore = GameObject.FindWithTag("ScoreText").GetComponent<TMP_Text>();

        gameOverCanvas = GameObject.Find("GameOverCanvas");
        loseText = GameObject.Find("LoseText");
        winText = GameObject.Find("WinText");

        player = GameObject.FindWithTag("Player");
        stall = GameObject.FindWithTag("Stall");

        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // timer
        if (counting)
        {
            timer -= Time.deltaTime;
            timerSeconds.text = timer.ToString("f2");
        }
        
        // Game Over
        if (timer <= 0 || currentScore == 10f)
        {
            counting = false;

            GameOver();
        }
    }

    public void UpdateScore(float score)
    {
        currentScore += score;
        textScore.text = "Chickens collected: " + currentScore + "/10".ToString();
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        player.GetComponent<PlayerController>().enabled = false;
        stall.GetComponent<CCollect>().enabled = false;

        // Game Won
        if (currentScore >= winScore)
        {
            loseText.SetActive(false);
            winText.SetActive(true);
        }

        // Game Lost
        if (currentScore < winScore)
        {
            loseText.SetActive(true);
            winText.SetActive(false);
        }
    }
}
