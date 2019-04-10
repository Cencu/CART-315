using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour
{
    public Score theScore;
    public float restPosi = 0f;
    public float pressedPosi = 45f;
    public float hitStr = 100f;
    public float paddleDamper = 20f;

    public string inputName;

    HingeJoint hinge;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStr;
        spring.damper = paddleDamper;
        if(Input.GetAxis(inputName)==1)
        {
            spring.targetPosition = pressedPosi;
            this.GetComponent<AudioSource>().Play();

        }
        else
        {
            spring.targetPosition = restPosi;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
