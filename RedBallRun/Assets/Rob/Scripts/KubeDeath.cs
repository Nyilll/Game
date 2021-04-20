using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KubeDeath : Death
{
    
    public override void HandleDeath()
    {
        Debug.Log("You'll Pay For This");
        Destroy(gameObject);
    }
}
