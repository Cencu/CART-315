using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowHook : MonoBehaviour
{
    public GameObject hook;
    //reference to the hook that exists in that moment
    GameObject currentHook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 destiny = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentHook = (GameObject)Instantiate (hook, transform.position, Quaternion.identity);

            currentHook.GetComponent<ropeScript>().destiny = destiny;
        }
    }
}
