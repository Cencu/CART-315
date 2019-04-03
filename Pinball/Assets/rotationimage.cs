using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationimage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        iTween.RotateBy(gameObject, iTween.Hash("z", .25, "easeType", "easeInOut", "loopType", "pingPong", "delay", 0));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
