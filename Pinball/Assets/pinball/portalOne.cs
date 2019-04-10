using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalOne : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject Ball;

    private void OnTriggerEnter(Collider other)
    {
        Ball.transform.position = teleportTarget.transform.position;
        this.GetComponent<AudioSource>().Play();

    }
}
