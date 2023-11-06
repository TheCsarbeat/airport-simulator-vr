using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyObjects : MonoBehaviour
{   
    int cant = 0;
    public GameObject phone;
    public GameObject shoes;

    public GameObject planeCollition;
    public GameObject planeGreenScaner;

    //flag to check if the objects are in collision
    bool phoneInCollision = false;
    bool shoesLeftInCollision = false;
    bool shoesRightInCollision = false;


    // Start is called before the first frame update
    void Start()
    {
        cant = 0;
        phone.SetActive(false);
        shoes.SetActive(false);
        planeGreenScaner.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the passport by checking its name
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "mobile")
        {   // Create a canvas right on top of the table
            phoneInCollision = true;
        }
        if (collision.gameObject.name == "nikeLeft")
        {   // Create a canvas right on top of the table
            shoesLeftInCollision = true;
        }
        if (collision.gameObject.name == "nikeRight")
        {   // Create a canvas right on top of the table
            shoesRightInCollision = true;
        }

        if (phoneInCollision && shoesLeftInCollision && shoesRightInCollision)
        {

            activePlaneGreenScaner();
        }


    }

    public void activePhone()
    {
        phone.SetActive(true);
        
    }

    public void activeShoes()
    {
        shoes.SetActive(true);
        
    }

    public void activePlaneGreenScaner()
    {
        planeGreenScaner.SetActive(true);
        planeCollition.SetActive(false);
        
    }

}
