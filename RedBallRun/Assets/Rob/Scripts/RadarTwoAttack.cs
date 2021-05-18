using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarTwoAttack : MonoBehaviour
{
    public GameObject turretBulletPrefab;
    public Transform nozzle;
    public float reloadTime = 0.6f;
    public bool reloading;
    // public EnemyRadar radar; For moving enemies
    public RadarTwoTurret radar;


    void Start()
    {
        radar = GetComponent<RadarTwoTurret>();
    }

    void Update()
    {
        if (radar.isActive && !reloading)
        {
            Instantiate(turretBulletPrefab, nozzle.position, nozzle.rotation);
            StartCoroutine("Reload");
        }
    }

    IEnumerator Reload()
    {
        reloading = true;
        yield return new WaitForSeconds(reloadTime);
        reloading = false;
    }
}
