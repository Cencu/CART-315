using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float delay = 5f;

    public GameObject explosionEffect;
    public float blastRadi = .1f;
    float countdown;
    public float force = .1f;
    bool hasExploded = false;
    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
           Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        //show explosion effect
        Instantiate(explosionEffect, transform.position, transform.rotation);
        //get nearby objects
        //allows us to define a sphere at a given posi with a radi
        //unity will give us a list of colliding objects
       Collider[] colliders =  Physics.OverlapSphere(transform.position, blastRadi);
        foreach (Collider nearbyObject in colliders)
        {
            //add force
          Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, blastRadi);
            }
        }
        //damage them
        //remove grenade
        Destroy(gameObject);
    }

}
