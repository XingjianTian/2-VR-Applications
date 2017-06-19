using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public GameObject []TargetImage;
    public AudioSource PhotoAudio;
    public float timeToSelect = 10.0f;
    public float countDown;
    public Vector3 hitposition;
    public Vector3 meposition;
    public float distance;
	// Use this for initialization
	void Start () {
        countDown = timeToSelect;
	}
	
	// Update is called once per frame
	void Update () {
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        RaycastHit hit;
       

        if (Physics.Raycast(ray,out hit))
        {
            meposition = Camera.main.transform.position;
            hitposition = hit.point;
            distance = Vector3.Distance(hitposition, meposition);

            if (distance < 1.8f)
            {

                bool IfIsImage = false;
                foreach (var EachImage in TargetImage)
                    if (hit.collider.gameObject == EachImage)
                        IfIsImage = true;

                if (IfIsImage)
                {
                    PhotoAudio = hit.collider.gameObject.GetComponent<AudioSource>();
                    if (countDown > 0.0f&&!PhotoAudio.isPlaying)
                        countDown -= Time.deltaTime;
                    else
                        //PhotoAudio = hit.collider.gameObject.GetComponent<AudioSource>();
                        if(!PhotoAudio.isPlaying)
                            PhotoAudio.Play();
                        else
                            countDown = timeToSelect;
                }
            }
            else
                countDown = timeToSelect;
        }
	}
}
