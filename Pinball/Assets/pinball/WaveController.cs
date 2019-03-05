using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{

    public float height;
    public float time;
    private Vector3 startPos;
    public GameObject Wavy;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        startPos = Wavy.transform.position;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == Ball)
        {
            iTween.MoveBy(this.gameObject, iTween.Hash("y", height, "time", time, "looptype", "pingpong", "eastype", iTween.EaseType.easeInOutSine));
            Wavy.transform.position = startPos;
            Debug.Log("higf");
        }
    }
}
