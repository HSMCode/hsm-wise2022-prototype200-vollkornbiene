using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerStart : MonoBehaviour
{
    private Button startButton;
    private Button demoButton;

    void Start()
    {
        startButton = GameObject.FindWithTag("StartGameButton").GetComponent<Button>();
        demoButton = GameObject.FindWithTag("DemoButton").GetComponent<Button>();

        startButton.onClick.AddListener(StartGame);
        demoButton.onClick.AddListener(StartDemo);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Radical Chicken Collection");
    }

    void StartDemo()
    {
        SceneManager.LoadScene("Demo");
    }
}
