using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarTwoTurret : MonoBehaviour
{
    public GameObject player;
    public bool isActive;
    public Transform target;

    void Update()
    {
        
      transform.LookAt(target);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entered Radar");
            isActive = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Exited Radar");
            isActive = false;
        }
    }

    
}
