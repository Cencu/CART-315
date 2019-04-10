using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationimage : MonoBehaviour
{

    public GameObject portal;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        portal.transform.Rotate(0, 1, 0, Space.Self);

    }
}
