using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndromedaScript : MonoBehaviour {
    Animator animAndromeda;

	// Use this for initialization
	void Start () {
        animAndromeda = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            animAndromeda.SetTrigger("isJumping");
        }
	}
}
