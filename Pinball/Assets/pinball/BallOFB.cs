using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOFB : MonoBehaviour
{
    private Vector3 initialPosition;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = Ball.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            Ball.transform.position = initialPosition;

        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == Ball)
        {
            Debug.Log("noooo");
            Ball.transform.position = initialPosition;
        }
    }
}
