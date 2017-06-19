using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(RePositionWithDelay());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator RePositionWithDelay()
    {
        while(true)
        {
            SetRandomPosition();
            yield return new WaitForSeconds(5);
        }
    }
    void SetRandomPosition()
    {
        float x = Random.Range(-30.0f, 40.0f);
        float z = Random.Range(-23.0f, 27.0f);
        transform.position = new Vector3(x, 0.0f,z);
    }

}
