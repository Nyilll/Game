using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float translateSpeed = 10f;
    public bool useAbsoluteMotion;
    public Rigidbody rigidBody;

    public bool usePhysicalMotion;
    public float physicalSpeed = 60f;
    

    // Start is called before the first frame update
    void Start()
    { 
        rigidBody = gameObject.GetComponent<Rigidbody>(); 

    }

    // Update is called once per frame
    void Update()
    {

        
        // Debug.Log(Input.GetAxis("Horizontal"));
        horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * translateSpeed;
        // Debug.Log(Input.GetAxis("Vertical")); //This line is here for practice
        verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * translateSpeed;

        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput);

        //check if we absolute or relative motion
        if (useAbsoluteMotion)
        {
            //use absolute
            if (usePhysicalMotion)
            {
                //use forces
                GetComponent<Rigidbody>().AddForce(movementDirection * physicalSpeed);
            }
            else
            {
                // use translate, no forces
                transform.Translate(movementDirection, Space.World);
            }
        }
        else
        {
            //use relative
            transform.Translate(movementDirection);
        }

        

        // Debug.Log(Input.mousePosition); This is the rotation
        // Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
             Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = gameObject.transform.position.y;
        // Debug.Log(mousePosition);
        transform.LookAt(mousePosition);

        

    }

    /*void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.name == "Plane")
        {
            rigidBody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
        }
    }*/

    

   
}

// when the player collides with the plane, freeze the y constrain

