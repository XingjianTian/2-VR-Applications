using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyWalk : MonoBehaviour {
    private HeadLookWalk lookwalk;
    //private AudioSource footsteps;
    private Transform head;
    private Transform body;
	// Use this for initialization
	void Start () {
        //lookwalk = GetComponent<HeadLookWalk>();
        //footsteps = GetComponent<AudioSource>();
        head = Camera.main.transform;
        body = transform.Find("MeBody");
	}
	
	// Update is called once per frame
	void Update () {
		
            body.transform.rotation = Quaternion.Euler(
                new Vector3(0.0f, head.transform.eulerAngles.y, 0.0f));
        /*
        if (!footsteps.isPlaying)
            footsteps.Play();
        else
            footsteps.Stop();*/
	}
}
