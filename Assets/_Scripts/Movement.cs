using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Animator animation;
    public float speed = 1f;


	void Start ()
    {
        animation = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetAxis("Vertical") > 0)
        {
            Vector3 velocity = transform.forward * speed;
            animation.SetBool("isWalking", true);
        }

        else
        {
            animation.SetBool("isWalking", false);
        }
	}
}
