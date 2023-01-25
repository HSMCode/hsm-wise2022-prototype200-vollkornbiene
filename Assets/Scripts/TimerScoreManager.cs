using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScoreManager : MonoBehaviour
{
    public string LevelToLoad;

    // for timer
    private float timer = 160f;
    public TMP_Text timerSeconds;

    // for score
    public float score;
    public float currentScore;
    public TMP_Text textScore;

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GameObject.Find("TimerText").GetComponent<TMP_Text>();
        textScore = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // timer
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");

        // Game Over
        if (timer <= 0 || currentScore == 10f)
        {
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
        // Game Won
        if (currentScore >= 8f)
        {
            SceneManager.LoadScene("VictoryScreen");
        }

        // Game Lost
        if (currentScore < 8f)
        {
            SceneManager.LoadScene("Lose");
        }
    }

}
