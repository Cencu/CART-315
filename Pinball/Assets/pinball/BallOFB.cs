using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOFB : MonoBehaviour
{
    private Vector3 initialPosition;
    public GameObject Ball;
    public Score theScore;

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
            theScore.addScore(1);

        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == Ball)
        {
            Ball.transform.position = initialPosition;
        }
    }
}
