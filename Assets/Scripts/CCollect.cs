using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCollect : MonoBehaviour
{   

    private GameObject Chicken;
    private GameObject Chicken1;
    private GameObject Chicken2;
    private GameObject Chicken3;
    private GameObject Chicken4;
    private GameObject Chicken5;
    private GameObject Chicken6;
    private GameObject Chicken7;
    private GameObject Chicken8;
    private GameObject Chicken9;
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {   
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Chicken = GameObject.FindGameObjectWithTag("Chicken");
        Chicken1 = GameObject.FindGameObjectWithTag("Chicken1");
        Chicken2 = GameObject.FindGameObjectWithTag("Chicken2");
        Chicken3 = GameObject.FindGameObjectWithTag("Chicken3");
        Chicken4 = GameObject.FindGameObjectWithTag("Chicken4");
        Chicken5 = GameObject.FindGameObjectWithTag("Chicken5");
        Chicken6 = GameObject.FindGameObjectWithTag("Chicken6");
        Chicken7 = GameObject.FindGameObjectWithTag("Chicken7");
        Chicken8 = GameObject.FindGameObjectWithTag("Chicken8");
        Chicken9 = GameObject.FindGameObjectWithTag("Chicken9");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Chicken")
        {
            scoreManager.score += 1f;
            Destroy(Chicken);
        }

        if (collision.tag == "Chicken1")
        {
            scoreManager.score += 1f;
            Destroy(Chicken1);
        }

        if (collision.tag == "Chicken2")
        {
            scoreManager.score += 1f;
            Destroy(Chicken2);
        }

        if (collision.tag == "Chicken3")
        {
            scoreManager.score += 1f;
            Destroy(Chicken3);
        }

        if (collision.tag == "Chicken4")
        {
            scoreManager.score += 1f;
            Destroy(Chicken4);
        }

        if (collision.tag == "Chicken5")
        {
            scoreManager.score += 1f;
            Destroy(Chicken5);
        }

        if (collision.tag == "Chicken6")
        {
            scoreManager.score += 1f;
            Destroy(Chicken6);
        }

        if (collision.tag == "Chicken7")
        {
            scoreManager.score += 1f;
            Destroy(Chicken7);
        }

        if (collision.tag == "Chicken8")
        {
            scoreManager.score += 1f;
            Destroy(Chicken8);
        }

        if (collision.tag == "Chicken9")
        {
            scoreManager.score += 1f;
            Destroy(Chicken9);
        }
    }
}
