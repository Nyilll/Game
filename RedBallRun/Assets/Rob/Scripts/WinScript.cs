using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public GameCore gameCore;
    public GameObject player;


    void Start()
    {
        gameCore = GameObject.FindObjectOfType<GameCore>();
    }

    private void OnTriggerEnter(Collider player)
    {
        Debug.Log("Level Complete");
        gameCore.NextLevel();
    }
}
