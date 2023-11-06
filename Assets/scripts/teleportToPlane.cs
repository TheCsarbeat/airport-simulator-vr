using Unity.XR.CoreUtils;
using UnityEngine;

public class teleportToPlane : MonoBehaviour
{
    public XROrigin  origin;
    public Transform cameraTransform; // Assign your Camera's transform here
    public GameObject plane;

    public bool buttionCliked = false;

    public float speed = 10;

    public Vector3 targetPlane;
    public Vector3 targetOrigin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if the orgin move inside the plane  
        Vector3 moveInsidePlane = origin.transform.localPosition;
        targetOrigin.y = moveInsidePlane.y;
        targetOrigin.z = moveInsidePlane.z;


        if(buttionCliked == true)
        {
            //move the plane         
            plane.transform.position = Vector3.MoveTowards(plane.transform.position, targetPlane, speed * Time.deltaTime);
            
            //move the origin
            origin.transform.position = Vector3.MoveTowards(origin.transform.position, targetOrigin, speed * Time.deltaTime);
        }

        if(plane.transform.position == targetPlane)
        {
            buttionCliked = false;
            speed = 0;
        }

    }

    public void getNewTarget(){
        //get the new target position of the  plane
        Vector3 currentPlanePosition = plane.transform.localPosition;
        currentPlanePosition.x = currentPlanePosition.x * -1;
        targetPlane = currentPlanePosition;

        //get the new target position of the origin
        Vector3 currentOriginPosition = origin.transform.localPosition;
        currentOriginPosition.x = currentOriginPosition.x * -1;
        targetOrigin = currentOriginPosition;

        //print the position of the target
        Debug.Log("target localposition: " + targetOrigin);


        speed = 10f;

    }

    public void TeleportIntoPlane()
    {
        //get the plane position
        

        Vector3 newPosition = new Vector3(-239.07f, 154.5f, -508.4792f);
       

        // Calculate the offset from the XR Origin to the Camera
        Vector3 offset = cameraTransform.localPosition;

        // Adjust the target position by the offset
        // This ensures that the camera ends up at the correct position
        Vector3 adjustedPosition = newPosition - offset;


        origin.transform.localPosition = adjustedPosition;

        getNewTarget();
        buttionCliked = true;

        //PlayAnimation();
        
    }


}
