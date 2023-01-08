using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCollect : MonoBehaviour
{   
    private GameObject Chicken;
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {   
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
 //     Chicken = GameObject.FindWithTag ("Chicken");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreManager.score += 1;
        Chicken = GameObject.FindWithTag ("Chicken");
        if (collision.tag == "Chicken")
        {
            Destroy(Chicken);
        }
    }
}
