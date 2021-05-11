using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetObject;

    public Vector3 cameraOffset;

    public float smoothFactor = 0.5f;

    public bool lookAtTarget = false;


    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position; // targetObject.transform.position;  (This freezes the player rotation, potentially due to the falling start)
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (targetObject.position.y > 0)
        {
            Vector3 newPosition = targetObject.transform.position + cameraOffset;
            transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);
        }
      
        //this might be unnecessary
        if (lookAtTarget)
        {
            transform.LookAt(targetObject);
        }
       

    }
}
