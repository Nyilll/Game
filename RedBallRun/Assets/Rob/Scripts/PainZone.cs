using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainZone : MonoBehaviour
{
    public int damage = 7;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ouch Charlie!");
        if (other.attachedRigidbody.gameObject.TryGetComponent(out Health health))
        {
            health.Damage(damage);
        }
    }
}
