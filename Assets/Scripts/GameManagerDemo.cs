using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerDemo : MonoBehaviour
{
    private Button startButton;

    void Start()
    {
        startButton = GameObject.FindWithTag("StartGameButton").GetComponent<Button>();

        startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Radical Chicken Collection");
    }
}
