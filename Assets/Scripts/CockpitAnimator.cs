using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockpitAnimator : MonoBehaviour {

     Animator anim;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	private void Update () {


        if (Input.GetKey(KeyCode.W))
        {
            //is walking
            anim.SetBool("Walking", true);
            anim.SetBool("Idle", false);
        }

        else
        {
            //Is Idle
            anim.SetBool("Walking", false);
            anim.SetBool("Idle", true);


        }

    }
}

