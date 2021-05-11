using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : Death
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    public override void HandleDeath()
    {
        Debug.Log("DEFEAT");
        player.transform.position = respawnPoint.transform.position;
        Physics.SyncTransforms();
    }
}
