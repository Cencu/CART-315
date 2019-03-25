using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenL : MonoBehaviour
{

    public GameObject MissileStylized;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == MissileStylized)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

        }
    }

}
