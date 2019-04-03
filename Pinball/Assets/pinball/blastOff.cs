using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blastOff : MonoBehaviour
{

    public GameObject Ball;
    public GameObject End;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Ball)
        {
            Debug.Log("hit");
            End.transform.Translate(0, Time.deltaTime * 2, 0, Space.World);

            Ball.transform.Translate(0, Time.deltaTime * 2,0, Space.World);
            Ball.GetComponent<Rigidbody>().useGravity = false;
            Ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
           // Ball.GetComponent<Collider>().enabled = false;

        }
    }

}
