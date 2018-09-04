using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndromedaScript : MonoBehaviour {
    static Animator animAndromeda;
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;


	// Use this for initialization
	void Start () {
        animAndromeda = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update() {
        //wasd controlls
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        //Jumping
        if (Input.GetButtonDown("Jump"))
        {
            animAndromeda.SetTrigger("isJumping");
        }

        //run animate
        if (translation != 0)
        {
            animAndromeda.SetBool("isRunning", true);
        }
        else
        {
            animAndromeda.SetBool("isRunning", false);
        }
	}
}
