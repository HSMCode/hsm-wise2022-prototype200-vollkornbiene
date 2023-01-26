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

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GameObject.Find("TimerText").GetComponent<TMP_Text>();
        textScore = GameObject.FindWithTag("ScoreText").GetComponent<TMP_Text>();
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

        // for game over screen dont destroy score and timer
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateScore(float score)
    {
        currentScore += score;
        textScore.text = "Chickens collected: " + currentScore + "/10".ToString();
    }

    public void GameOver()
    {
        
        // Game Won
        if (currentScore >= winScore)
        {
            SceneManager.LoadScene("Win");

            timerSeconds = GameObject.Find("TimerText").GetComponent<TMP_Text>();
            textScore = GameObject.FindWithTag("ScoreText").GetComponent<TMP_Text>();

            textScore.text = "Chickens collected: " + currentScore + "/10".ToString();
            timerSeconds.text = "Time remaining: " + timer.ToString();
        }

        // Game Lost
        if (currentScore < winScore)
        {
            SceneManager.LoadScene("Lose");

            textScore = GameObject.FindWithTag("ScoreText").GetComponent<TMP_Text>();

            textScore.text = "Chickens collected: " + currentScore + "/10".ToString();
        }
    }

}
