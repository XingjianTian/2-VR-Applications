using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyAC : MonoBehaviour
{
    protected Animator animator;
    public float DirectionDampTime = .25f;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator)
        {
            AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

            if (stateInfo.IsName("Base Layer.Run"))
                animator.SetBool("Runs", true);
            else
                animator.SetBool("Idles", false);

            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            animator.SetFloat("Speed", h * h + v * v);
            animator.SetFloat("Direction", h, DirectionDampTime, Time.deltaTime);
        }
    }
}