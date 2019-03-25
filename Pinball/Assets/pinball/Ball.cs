using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool inWindZone = false;
    public GameObject windZone;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (inWindZone)
        {
            rb.AddForce(windZone.GetComponent<WindArea>().direction * windZone.GetComponent<WindArea>().strength);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "windArea")
        {
            
                windZone = col.gameObject;
                inWindZone = true;
                Debug.Log("spdoa");
               
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
