using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
    
{
    public GameObject BreakableWall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision!");

        if(other.gameObject.TryGetComponent(out PlayerBullet bullet))
        {
            Destroy(bullet.gameObject);
            Destroy(BreakableWall.gameObject); 
        }
    }
}
