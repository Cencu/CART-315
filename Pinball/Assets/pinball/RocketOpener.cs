using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{

    public class RocketOpener : MonoBehaviour
    {
        public Vector3andSpace moveUnitsPerSecond;
        public Vector3andSpace rotateDegreesPerSecond;
        public bool ignoreTimescale;
        private float m_LastRealTime;
        public GameObject Ball;
        public GameObject Sliding_Door;

        //public float delay = 5f;

        public GameObject explosionEffect;
        public float blastRadi = .1f;
       // float countdown;
        public float force = .1f;
        bool hasExploded = false;

        private void Start()
        {
            m_LastRealTime = Time.realtimeSinceStartup;
        }


        // Update is called once per frame
        private void Update()
        {
           /* float deltaTime = Time.deltaTime;
            if (ignoreTimescale)
            {
                deltaTime = (Time.realtimeSinceStartup - m_LastRealTime);
                m_LastRealTime = Time.realtimeSinceStartup;
            }
            transform.Translate(moveUnitsPerSecond.value * deltaTime, moveUnitsPerSecond.space);
            transform.Rotate(rotateDegreesPerSecond.value * deltaTime, moveUnitsPerSecond.space);
            //  }*/
        }

        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject == Ball)
            {
                float deltaTime = Time.deltaTime;
                if (ignoreTimescale)
                {
                    deltaTime = (Time.realtimeSinceStartup - m_LastRealTime);
                    m_LastRealTime = Time.realtimeSinceStartup;
                }
                transform.Translate(moveUnitsPerSecond.value * deltaTime, moveUnitsPerSecond.space);
                transform.Rotate(rotateDegreesPerSecond.value * deltaTime, moveUnitsPerSecond.space);
                //  }
            }
            if (collision.gameObject == Sliding_Door)
            {
                Explode();
            }
        }

        public void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject == Ball) { 
            float deltaTime = Time.deltaTime;
            if (ignoreTimescale)
            {
                deltaTime = (Time.realtimeSinceStartup - m_LastRealTime);
                m_LastRealTime = Time.realtimeSinceStartup;
            }
            transform.Translate(moveUnitsPerSecond.value * deltaTime, moveUnitsPerSecond.space);
            transform.Rotate(rotateDegreesPerSecond.value * deltaTime, moveUnitsPerSecond.space);
              }
        }

        [Serializable]
        public class Vector3andSpace
        {
            public Vector3 value;
            public Space space = Space.Self;
        }

        void Explode()
        {
            //show explosion effect
            Instantiate(explosionEffect, transform.position, transform.rotation);
            //get nearby objects
            //allows us to define a sphere at a given posi with a radi
            //unity will give us a list of colliding objects
            Collider[] colliders = Physics.OverlapSphere(transform.position, blastRadi);
            foreach (Collider nearbyObject in colliders)
            {
                //add force
                Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(force, transform.position, blastRadi);
                }
            }
            //damage them
            //remove grenade
            Destroy(gameObject);
        }


    }
}