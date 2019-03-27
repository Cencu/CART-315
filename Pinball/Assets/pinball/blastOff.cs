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

    private void OnTrigger(Collider other)
    {
        if (other.gameObject == Ball)
        {
            End.transform.Translate(0, 0, Time.deltaTime * 1000);
            Ball.transform.Translate(0, 0, Time.deltaTime * 2);


        }
    }

}
