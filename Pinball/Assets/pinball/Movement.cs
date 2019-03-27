using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

        }
    }
}
