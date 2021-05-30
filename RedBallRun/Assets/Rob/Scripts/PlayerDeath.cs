using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : Death
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;


    // 18/5
    
    public GameCore gameCore;

    void Start()
    {
        gameCore = GameObject.FindObjectOfType<GameCore>();
    }



    public override void HandleDeath()
    {
        Debug.Log("DEFEAT");
                                                                                                                                        // gameCore.decreasePlayerLives();
        player.transform.position = respawnPoint.transform.position;
        Physics.SyncTransforms();

    }
}
