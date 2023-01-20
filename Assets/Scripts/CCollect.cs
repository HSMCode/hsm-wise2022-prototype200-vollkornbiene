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

    private TimerScoreManager scoreManager;

    public float score = 1f;

    AudioSource audioSource;
    public AudioClip ChickenScream;

    // Start is called before the first frame update
    void Start()
    {   
        scoreManager = GameObject.Find("TimerScore").GetComponent<TimerScoreManager>();
        audioSource = GetComponent<AudioSource>();
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
            scoreManager.UpdateScore(score);
            Destroy(Chicken);
            audioSource.PlayOneShot(ChickenScream, 0.2f);
        }

        if (collision.tag == "Chicken1")
        {
            scoreManager.UpdateScore(score);
            Destroy(Chicken1);
            audioSource.PlayOneShot(ChickenScream, 0.2f);
        }

        if (collision.tag == "Chicken2")
        {
            scoreManager.UpdateScore(score);
            Destroy(Chicken2);
            audioSource.PlayOneShot(ChickenScream, 0.2f);
        }

        if (collision.tag == "Chicken3")
        {
            scoreManager.UpdateScore(score);
            Destroy(Chicken3);
            audioSource.PlayOneShot(ChickenScream, 0.2f);
        }

        if (collision.tag == "Chicken4")
        {
            scoreManager.UpdateScore(score);
            Destroy(Chicken4);
            audioSource.PlayOneShot(ChickenScream, 0.2f);
        }

        if (collision.tag == "Chicken5")
        {
            scoreManager.UpdateScore(score);
            Destroy(Chicken5);
            audioSource.PlayOneShot(ChickenScream, 0.2f);
        }

        if (collision.tag == "Chicken6")
        {
            scoreManager.UpdateScore(score);
            Destroy(Chicken6);
            audioSource.PlayOneShot(ChickenScream, 0.2f);
        }

        if (collision.tag == "Chicken7")
        {
            scoreManager.UpdateScore(score);
            Destroy(Chicken7);
            audioSource.PlayOneShot(ChickenScream, 0.2f);
        }

        if (collision.tag == "Chicken8")
        {
           scoreManager.UpdateScore(score);
            Destroy(Chicken8);
            audioSource.PlayOneShot(ChickenScream, 0.2f);
        }

        if (collision.tag == "Chicken9")
        {
            scoreManager.UpdateScore(score);
            Destroy(Chicken9);
            audioSource.PlayOneShot(ChickenScream, 0.2f);
        }
    }
}
