using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerEnd : MonoBehaviour
{
    private Button startButton;
    private Button quitButton;

    void Start()
    {
        startButton = GameObject.FindWithTag("StartGameButton").GetComponent<Button>();
        quitButton = GameObject.FindWithTag("QuitButton").GetComponent<Button>();

        startButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Radical Chicken Collection");
    }

    void QuitGame()
    {
        SceneManager.LoadScene("Start");
    }
}
