using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject playerBulletPrefab;
    public Transform nozzle;
    /*public float reloadTime = 0.6f;
    public bool reloading;*/

    /* Bullet Sounds on the Fire2 broke the sound since it instantiates a bullet every frame or w.e.
     * and only having sound on one attack type would be dumb so bgm only it is. 
    public AudioSource audiosource;
    public AudioClip bulletSoundOne;
    public AudioClip bulletSoundTwo; */

    // Start is called before the first frame update
    void Start()
    {
      /*  audiosource = gameObject.GetComponent<AudioSource>(); */

    }

    // Update is called once per frame
    void Update()
    {
     
            if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1");
            Instantiate(playerBulletPrefab, nozzle.position, nozzle.rotation);
            /* audiosource.PlayOneShot(bulletSoundOne);*/
        }

            if (Input.GetButton("Fire2") /*&& !reloading*/)
        {
            Debug.Log("Fire2");
            Instantiate(playerBulletPrefab, nozzle.position, nozzle.rotation);
            /* audiosource.PlayOneShot(bulletSoundTwo); */
            /*StartCoroutine("Reload");*/
        }

        
    }

    /*IEnumerator Reload()
    {
        reloading = true;
        yield return new WaitForSeconds(reloadTime);
        reloading = false;
    }*/

}
