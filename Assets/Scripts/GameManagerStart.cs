using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerStart : MonoBehaviour
{
    public Button startButton;
    public Button demoButton;

    void Start()
    {
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
