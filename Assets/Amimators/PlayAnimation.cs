using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour {

    public Animator animator;
    private float inTime;

	// Use this for initialization
	void Start () {

        animator = this.GetComponent<Animator>();

	
	}
	
	// Update is called once per frame
	void Update () {

        if (animator)
        {
            AnimatorStateInfo stateinfo = animator.GetCurrentAnimatorStateInfo(0);
            if (stateinfo.nameHash == Animator.StringToHash("Base Layer.WAIT00"))
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
 
                }
            }
        }
	
	}
}
