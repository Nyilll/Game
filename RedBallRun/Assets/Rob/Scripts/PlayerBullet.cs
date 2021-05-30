using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public Rigidbody rbody;
    public float speed = 10;
    public float lifespan = 1f;

    public int damage = 4;
   /* public AudioSource audiosource;
    public AudioClip impactSound; */

    void Start()
    {
        // audiosource = gameObject.GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Awake()
    {
        rbody = GetComponent<Rigidbody>();
        rbody.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, lifespan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.root.gameObject.TryGetComponent(out Health hp))
        {
            hp.Damage(damage);
            Destroy(gameObject);
        }
        /* StartCoroutine("HandleBulletCollision"); */
    }

    /* private IEnumerator HandleBulletCollision()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        audiosource.PlayOneShot(impactSound);
        yield return new WaitForSeconds(impactSound.length);



    }
    btws this is impact sound */
}
