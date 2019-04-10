using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{   //Every attractor needs a rigidbody, so we keep it public and call it rb
    public Rigidbody rb;

    //create a constant
    const float G = 8;

    private void FixedUpdate()
    {
        //array of attractor objects, we find them all and put them in the array
        Attractor[] attractors = FindObjectsOfType<Attractor>();
        //loop through all the attractor components 
        foreach (Attractor attractor in attractors)
        {
            if (attractor != this) { 
            //the object to attract is the attractor were currently looking at
            Attract(attractor);

            }
        }
    }

    void Attract (Attractor objToAttract)
    {
        //Newtons law of universal gravitation:
        //force = the mass * mass / distance * gravitational pull
        //we get the rigidbody we want to attract and set it to the object 
        Rigidbody rbToAttract = objToAttract.rb;
        //Get the direction between the obj were trying to attract to this object
        Vector3 direction = rb.position - rbToAttract.position;
        //get the distance between both objs
        float distance = direction.magnitude;
        //calculate force. mass of one obj, * mass of other other obj
        //divided by the distance between them squared
        //Mathf.Pow lifts a number to square, so distance2
        float forceMagnitude = G* (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        //apply a force in the direction of our object with a strenght defined by newtons equation
        
        Vector3 force = direction.normalized * forceMagnitude;
        //apply the force
        rbToAttract.AddForce(force);

    }

  

}
