using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpdX = 5f;
    public float rotationSpdY = 5f;
    public float rotationSpdZ = 5f;
    public int healthBack = 20;
    

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(rotationSpdX * Time.deltaTime, rotationSpdY * Time.deltaTime , rotationSpdZ * Time.deltaTime);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Health>(out Health health))
        {
            health.Recover(healthBack);
            
        }
        
        Destroy(gameObject);
    }
}  