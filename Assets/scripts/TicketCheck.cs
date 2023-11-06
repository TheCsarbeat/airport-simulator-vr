using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketCheck : MonoBehaviour
{

    int cant = 0;
    public GameObject turnstile;
    public GameObject planeCollition;

    //flag to check if the objects are in collision
    bool phoneInCollision = false;
    bool shoesLeftInCollision = false;
    bool shoesRightInCollision = false;

    // Start is called before the first frame update
    void Start()
    {
        planeCollition.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the passport by checking its name
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "tickets")
        {   
            planeCollition.SetActive(true);
        }



    }
}
