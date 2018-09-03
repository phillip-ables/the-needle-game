using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour {

    Animator animZombie;

	// Use this for initialization
	void Start () {
        animZombie = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Vertical") > 0)
        {
            animZombie.SetTrigger("Walk");
        }
        else if(Input.GetAxis("Vertical") < 0)
        {
            animZombie.SetTrigger("Reverse");
        }
        else
        {
            animZombie.SetTrigger("Stop");
        }
	}
}
