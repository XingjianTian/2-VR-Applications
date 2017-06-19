using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureWalk : MonoBehaviour {
    private HeadLookWalk lookwalk;
    private HeadGesture gesture;
	// Use this for initialization
	void Start () {
        lookwalk = GetComponent<HeadLookWalk>();
        gesture = GameObject.Find("GameController").GetComponent<HeadGesture>();
	}
	
	// Update is called once per frame
	void Update () {
		if(gesture.isMovingDown)
        {
            lookwalk.isWalking = !lookwalk.isWalking;
        }
	}
}
