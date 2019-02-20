using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ropeScript : MonoBehaviour
{
    public Vector3 destiny;
    public float speed = 1;
    public float distance = 2f;
    public GameObject Node;
    public GameObject player;
    public GameObject lastNode;
    bool done = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Ball");
        lastNode = transform.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destiny, speed);
        if ((Vector3)transform.position != destiny )
        {
            if (Vector3.Distance(player.transform.position,lastNode.transform.position) > distance)
            {
                CreateNode();
            }
        } else if (done == false) {
            done = true;
            lastNode.GetComponent<HingeJoint>().connectedBody = player.GetComponent<Rigidbody>();

        }
    }

    void CreateNode()
    {
        Vector3 pos2Create = player.transform.position - lastNode.transform.position;
        pos2Create.Normalize();
        pos2Create *= distance;
        pos2Create += (Vector3)lastNode.transform.position;
        GameObject go = (GameObject) Instantiate(Node, pos2Create, Quaternion.identity);
        go.transform.SetParent(transform);
        lastNode.GetComponent<HingeJoint>().connectedBody = go.GetComponent<Rigidbody>();
        lastNode = go;


    }
}
