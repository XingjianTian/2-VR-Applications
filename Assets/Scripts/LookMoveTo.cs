using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMoveTo : MonoBehaviour {
    public GameObject ground;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward * 100.0f);
        RaycastHit[] hits = Physics.RaycastAll(ray);
        GameObject hitObject;
        for(int i = 0;i<hits.Length;i++)
        {
            RaycastHit hit = hits[i];
            hitObject = hit.collider.gameObject;
            if(hitObject==ground)
            {
                transform.position = hit.point;
            }
        }
       
	}
}
