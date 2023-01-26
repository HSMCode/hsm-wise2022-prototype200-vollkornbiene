using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] Button demoButton;

    void Update()
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
