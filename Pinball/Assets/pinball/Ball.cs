using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour
{
    public bool inWindZone = false;
    public GameObject windZone;
    Rigidbody rb;
   // public AudioClip restart;
    public AudioClip wind;
    public AudioSource audioSource;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (inWindZone)
        {
            rb.AddForce(windZone.GetComponent<WindArea>().direction * windZone.GetComponent<WindArea>().strength);
            audioSource.PlayOneShot(wind, 1f);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "windArea")
        {
            
                windZone = col.gameObject;
                inWindZone = true;
               
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "windArea")
        {
            inWindZone = false;
        }
    }
}
