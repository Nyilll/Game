using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject playerBulletPrefab;
    public Transform nozzle;
    public float reloadTime = 0.6f;
    public bool reloading;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
            if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1");
            Instantiate(playerBulletPrefab, nozzle.position, nozzle.rotation);
        }

            if (Input.GetButton("Fire2") && !reloading)
        {
            Debug.Log("Fire2");
            Instantiate(playerBulletPrefab, nozzle.position, nozzle.rotation);
            StartCoroutine("Reload");
        }

        
    }

    /*IEnumerator Reload()
    {
        reloading = true;
        yield return new WaitForSeconds(reloadTime);
        reloading = false;
    }*/

}
