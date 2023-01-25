using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button startButton;
    public Button demoButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        demoButton.onClick.AddListener(StartDemo);
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.R)) // 
    //    {
    //    SceneManager.LoadScene("Radical Chicken Collection"); 
    //    }
    //}

    void StartGame()
    {
        SceneManager.LoadScene("Radical Chicken Collection");
    }

    void StartDemo()
    {
        SceneManager.LoadScene("Demo");
    }
}
