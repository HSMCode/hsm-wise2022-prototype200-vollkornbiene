using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform holdSpot; //where spot when hold
    public LayerMask pickUpMask;
    public Vector3 Direction { get; set;} //for direction drop
    private GameObject itemHolding;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // E to PickUp
        {
            if(itemHolding) //Check if Item is holding
            {
                itemHolding.transform.position = transform.position + Direction; //to locate where to drop the item
                itemHolding.transform.parent = null; //remove item from player
                if (itemHolding.GetComponent<Rigidbody2D>())
                    itemHolding.GetComponent<Rigidbody2D>().simulated = true; //check for rigidbody if exist
                itemHolding = null;
            }

            else
            {
                Collider2D pickUpItem = Physics2D.OverlapCircle(transform.position + Direction, .2f, pickUpMask);
                if (pickUpItem)
                {
                itemHolding = pickUpItem.gameObject;
                itemHolding.transform.position = holdSpot.position; //item goes to spot
                itemHolding.transform.parent = transform; //item will follow player
                if (itemHolding.GetComponent<Rigidbody2D>()) //check if rigidbody2d is on item
                    itemHolding.GetComponent<Rigidbody2D>().simulated = false;
                }
            }

        }
    }
}
