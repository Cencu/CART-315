using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PinLauncher : MonoBehaviour
{
    public float power;
    public float maxPower = 100f;
    public float hitStr = 100f;
    public float paddleDamper = 20f;

    public string inputName;

    ConfigurableJoint hinge;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<ConfigurableJoint>();
        hinge. = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStr;
        spring.damper = paddleDamper;
        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosi;

        }
        else
        {
            spring.targetPosition = restPosi;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
