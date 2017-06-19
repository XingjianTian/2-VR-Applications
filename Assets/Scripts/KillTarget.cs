using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillTarget : MonoBehaviour {

    //public GameObject TargetEthan;
    public GameObject TargetTeddy;
    public ParticleSystem hitEffect;
    public GameObject killEffect;
    public float timeToSelect = 3.0f;
    public int score;
    public Text scoreText;
    private float countDown;
	// Use this for initialization
	void Start () {
        score = 0;
        countDown = timeToSelect;
        ParticleSystem.EmissionModule em = hitEffect.emission;
        em.enabled = false;
        scoreText.text = "Score: 0";
    }
	
	// Update is called once per frame
	void Update () {
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit) && (hit.collider.gameObject == TargetTeddy))
        {
            if(countDown>0.0f)
            {
                countDown -= Time.deltaTime;
                hitEffect.transform.position = hit.point;
                ParticleSystem.EmissionModule em = hitEffect.emission;
                em.enabled = true;
            }
            else
            {
                //Instantiate(killEffect, TargetEthan.transform.position, TargetEthan.transform.rotation);
                Instantiate(killEffect, TargetTeddy.transform.position, TargetTeddy.transform.rotation);
                score += 1;
                scoreText.text = "Score: " + score;
                countDown = timeToSelect;
                SetRandomPosition();
            }
        }
        else
        {
            countDown = timeToSelect;
            ParticleSystem.EmissionModule em = hitEffect.emission;
            em.enabled = false;
        }
	}

    void SetRandomPosition()
    {
        float x = Random.Range(-30.0f, 40.0f);
        float z = Random.Range(-23.0f, 27.0f);
        TargetTeddy.transform.position = new Vector3(x, 0.0f, z);
    }
}
