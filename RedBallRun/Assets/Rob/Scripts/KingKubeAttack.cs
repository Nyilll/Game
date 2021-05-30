using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingKubeAttack : MonoBehaviour
{
    public GameObject turretBulletPrefabOne;
    public GameObject turretBulletPrefabTwo;

    public Transform nozzleOne;
    public Transform nozzleTwo;
    public Transform nozzleThree;
    public Transform nozzleFour;

    public float reloadTimeOne = 0.6f;
    public float reloadTimeTwo = 0.6f;

    public bool reloadingOne;
    public bool reloadingTwo;

    public Transform target;
    /* public Vector3 targetPosition; */

   void Start()
    {
        /* use Quaternion.LookRotation or Vector3.RotateTowards to fix the x axis issues */
       /* targetPosition = target.position; */
    }


    void Update()
    {
        transform.LookAt(target);
        


        if (!reloadingOne)
        {
            Instantiate(turretBulletPrefabOne, nozzleOne.position, nozzleOne.rotation);
            Instantiate(turretBulletPrefabOne, nozzleTwo.position, nozzleTwo.rotation);
            StartCoroutine("ReloadOne");
        }

        if (!reloadingTwo)
        {
            Instantiate(turretBulletPrefabTwo, nozzleThree.position, nozzleThree.rotation);
            Instantiate(turretBulletPrefabTwo, nozzleFour.position, nozzleFour.rotation);
            StartCoroutine("ReloadTwo");
        }

    }

    IEnumerator ReloadOne()
    {
        reloadingOne = true;
        yield return new WaitForSeconds(reloadTimeOne);
        reloadingOne = false;
    }

    IEnumerator ReloadTwo()
    {
        reloadingTwo = true;
        yield return new WaitForSeconds(reloadTimeTwo);
        reloadingTwo = false;
    }
}