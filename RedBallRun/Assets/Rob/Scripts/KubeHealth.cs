using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KubeHealth : MonoBehaviour
{
    public int hp = 120;

    void Start()
    {

    }

    public void Damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {

            if (gameObject.TryGetComponent(out Death death))
            {
                death.HandleDeath();
            }
        }

    }
}