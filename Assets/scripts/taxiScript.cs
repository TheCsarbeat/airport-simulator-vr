using Unity.XR.CoreUtils;
using UnityEngine;

public class taxiScript : MonoBehaviour
{
    
    public XROrigin  origin;
    public Transform cameraTransform; // Assign your Camera's transform here
    public GameObject taxi;

    public bool buttionCliked = false;

    public float speed = 10;

    public Vector3 targetTaxi;
    public Vector3 targetOrigin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(buttionCliked == true)
        {
            //move the taxi         
            taxi.transform.position = Vector3.MoveTowards(taxi.transform.position, targetTaxi, speed * Time.deltaTime);
            
            //move the origin
            origin.transform.position = Vector3.MoveTowards(origin.transform.position, targetOrigin, speed * Time.deltaTime);
        }

        if(taxi.transform.position == targetTaxi)
        {
            buttionCliked = false;
            speed = 0;
        }

    }

    public void getNewTaxiTarget(){
        //get the new target position of the  taxi
        Vector3 currentTaxiPosition = taxi.transform.position;
        currentTaxiPosition.x += 80;
        targetTaxi = currentTaxiPosition;

        //get the new target position of the origin
        Vector3 currentOriginPosition = origin.transform.position;
        currentOriginPosition.x += 80;
        targetOrigin = currentOriginPosition;

        speed = 5f;

    }

    public void teleportIntoTaxi()
    {
        
       
       if (buttionCliked == false)
        {
            Vector3 newPosition = new Vector3(-78.277f, 2f, 35.861f);
            // Calculate the offset from the XR Origin to the Camera
            Vector3 offset = cameraTransform.localPosition;

            // Adjust the target position by the offset
            // This ensures that the camera ends up at the correct position
            Vector3 adjustedPosition = newPosition - offset;


            origin.transform.localPosition = adjustedPosition;
            buttionCliked = true;
            getNewTaxiTarget();
        }



        
    }



}
