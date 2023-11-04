using UnityEngine;

public class checkin : MonoBehaviour
{
    public GameObject confirmationCanvas;
    public GameObject tickets;

    // Start is called before the first frame update
    void Start()
    {
        confirmationCanvas.SetActive(false);
        tickets.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the passport by checking its name
        if (collision.gameObject.name == "passport")
        {
            // Assuming VR camera is a child of the player's head in the hierarchy
            // Create a canvas right on top of the table
            confirmationCanvas.SetActive(true);

            // You might want to disable the passport after the collision
            collision.gameObject.SetActive(false);
            tickets.SetActive(true);
        }
    }
}
