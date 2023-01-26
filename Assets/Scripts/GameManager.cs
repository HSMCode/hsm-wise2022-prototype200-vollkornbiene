using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button startButton;
    public Button demoButton;
    public Button quitButton;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        demoButton.onClick.AddListener(StartDemo);
        quitButton.onClick.AddListener(QuitGame);

        DontDestroyOnLoad(this.gameObject);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Radical Chicken Collection");
    }

    void StartDemo()
    {
        SceneManager.LoadScene("Demo");
    }

    void QuitGame()
    {
        SceneManager.LoadScene("Start");
    }
}
