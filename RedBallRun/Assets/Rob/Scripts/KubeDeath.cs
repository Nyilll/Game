using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KubeDeath : Death
{
    public GameCore gameCore;
    public int value = 10;

    void Start()
    {
        gameCore = GameObject.FindObjectOfType<GameCore>();
    }

    public override void HandleDeath()
    {
        Debug.Log("You'll Pay For This");
        gameCore.increasePlayerScore(value);
        Destroy(gameObject);
    }
}
