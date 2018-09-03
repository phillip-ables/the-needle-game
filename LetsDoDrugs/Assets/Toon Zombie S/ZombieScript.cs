using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour {

    Animator animZombie;
    public float walkSpeed = 10.0f;

	// Use this for initialization
	void Start () {
        animZombie = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update() {
        //if(Input.GetAxis("Vertical") != 0)
        //
        //Player Animate
        if (Input.GetKeyDown(KeyCode.UpArrow)
            || Input.GetKeyDown(KeyCode.DownArrow)
            || Input.GetKeyDown(KeyCode.RightArrow)
            || Input.GetKeyDown(KeyCode.LeftArrow)
            )
        {
            animZombie.SetBool("isWalking", true);
        }

        //Move 
        //Forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * Time.deltaTime * walkSpeed;
        }
        //Back
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= Vector3.forward * Time.deltaTime * walkSpeed;
        }
        //Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * walkSpeed;
        }
        //Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * walkSpeed;
        }

        //Stop Animation
        if (Input.GetKeyUp(KeyCode.UpArrow)
            || Input.GetKeyUp(KeyCode.DownArrow)
            || Input.GetKeyUp(KeyCode.RightArrow)
            || Input.GetKeyUp(KeyCode.LeftArrow)
            )
            //if(Input.GetAxis("Vertical") == 0)d
            {
            animZombie.SetBool("isWalking", false);
        }
	}
}
