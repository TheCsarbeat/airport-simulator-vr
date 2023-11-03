using Unity.XR.CoreUtils;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(XROrigin))]

public class NewBehaviourScript : MonoBehaviour
{
    public CharacterController characterController;
    public XROrigin origin;
    

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        origin = GetComponent<XROrigin>();

    }


    void FixedUpdate()
    {
        var center = transform.InverseTransformPoint(origin.Camera.transform.position);
        characterController.center = new Vector3(center.x, 
        characterController.height /2 + characterController.skinWidth,
        center.z);

    }



}
