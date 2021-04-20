using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMaker : MonoBehaviour

    
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
            Instantiate(prefab, new Vector3(1.5f * i, 0f, 4f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
