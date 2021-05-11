using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRadar : MonoBehaviour
{
    public GameObject player;
    public bool isActive;

    void Start()
    {
        
    }

    void Update()
    {
        if (isActive)
        {
            transform.LookAt(player.transform);
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entered Radar");
            isActive = true;
        }
    }

    private void OnTriggerExit (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Exited Radar");
            isActive = false;
        }
    }
}
