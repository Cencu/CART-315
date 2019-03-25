using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTop : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

        }

       /* if (Input.GetKey("up"))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey("down"))
        {
            transform.Rotate(0, -1, 0);
        }*/

        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

        }
    }
}
