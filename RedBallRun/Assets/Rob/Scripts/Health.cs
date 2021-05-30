using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 120;
    public GameCore gameCore;
    public int value = 10;

    void Start()
    {
        gameCore = GameObject.FindObjectOfType<GameCore>();
    }

    
    public void Recover(int recovery)
    {
        health += recovery;
        gameCore.Recovery();
        gameCore.increasePlayerScore(value);
    }
    public void Damage(int damage)
    {
        // Debug.Log("OWWW:" + damage);
        health -= damage;
        gameCore.Health(health);
        if (health <= 0)
        {
            //Debug.Log("DEAD");
            if (gameObject.TryGetComponent(out Death death))
            {
                death.HandleDeath();
                health = 120;
            }
            else
            {
                //Debug.Log("No Death script attached.");
            }
        }
    }
}
