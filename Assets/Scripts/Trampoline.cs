using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {
    public float bounceForce = 500f;
    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if(rb!=null)
        {
            rb.AddForce(Vector3.up * bounceForce);
        }
        else
        {
            HeadLookWalkBounce locomotor = other.GetComponent<HeadLookWalkBounce>();
            if (locomotor != null)
                locomotor.bounceForce = bounceForce;
        }
    }
}
