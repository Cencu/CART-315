using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchGravity : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 5f;
    public float mass;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 0 )
        {
            mass = Random.Range(-5, 10);
            currentTime = 5;

        }
       // Debug.Log(mass);

    }
}
