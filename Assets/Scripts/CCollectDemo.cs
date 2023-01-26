using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCollectDemo : MonoBehaviour
{
    private GameObject Chicken1;

    AudioSource audioSource;
    [SerializeField] AudioClip chickenScream;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Chicken1 = GameObject.FindGameObjectWithTag("Chicken1");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Chicken1")
        {
            Destroy(Chicken1);
            audioSource.PlayOneShot(chickenScream, 0.2f);
        }
    }
}
