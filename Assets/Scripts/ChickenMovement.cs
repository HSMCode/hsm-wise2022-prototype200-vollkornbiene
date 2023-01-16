using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    
    public Vector3 direction;
    public float speed;
    public bool walking;
    private Rigidbody2D _chickenrb;
    

    void Start()
    {
        _chickenrb = GetComponent<Rigidbody2D>();

        InvokeRepeating ("NewDirection", 3f, 3f); //repeat NewDirection every 3 seconds
    }


    void Update()
    {
        //add force in random direction and stop walking
        if(walking)
        {
            _chickenrb.AddForce(direction * speed, ForceMode2D.Force);
            walking = false;
        }
        
    }


    //get a random vector for direction 
    private void NewDirection()
    {
        direction = new Vector3(Random.Range(-1f,1f),Random.Range(-1f,1f),0);
        walking = true;
    }
}
