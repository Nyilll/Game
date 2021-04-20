using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 20;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Damage(int damage)
    {
        // Debug.Log("OWWW:" + damage);
        health -= damage;
        if (health <= 0)
        {
            Debug.Log("DEAD");
            if (gameObject.TryGetComponent(out Death death))
            {
                death.HandleDeath();
            }
            else
            {
                Debug.Log("No Death script attached.");
            }
        }
    }
}
