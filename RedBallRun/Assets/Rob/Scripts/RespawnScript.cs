using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{  
    //SerializeField causes this variable to be visible in inspector without making it public.
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            
        }
    }
}

/* Source : SpeedTutor on Youtube
 * https://www.youtube.com/watch?v=tB_ihytqGpo */