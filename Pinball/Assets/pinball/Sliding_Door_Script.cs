using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding_Door_Script : MonoBehaviour

{

    public GameObject trigger;
    public GameObject leftDoor;
    public GameObject rightDoor;

    Animator leftAnim;
    Animator rightAnim;

    // Start is called before the first frame update
    void Start()
    {
        leftAnim = leftDoor.GetComponent<Animator>();
        rightAnim = rightDoor.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider coll)
    {
       if (coll.gameObject.tag == "Rocket")
        {
           // Debug.Log("asd");
            SlideDoors(true);
        }
    }

    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Rocket")
        {
            SlideDoors(false);
            this.GetComponent<AudioSource>().Play();
            this.GetComponent<ConstantForce>().enabled = true;
        }
    }

    void SlideDoors(bool state)
    {
        leftAnim.SetBool("Slide", state);
        rightAnim.SetBool("Slide", state);

    }

}
