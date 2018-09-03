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
		//if(Input.GetAxis("Vertical") != 0)
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            animZombie.SetTrigger("Walk");
        }
        if(Input.GetKeyUp(KeyCode.UpArrow))
        //if(Input.GetAxis("Vertical") == 0)
        {
            animZombie.SetTrigger("Stop");
            Debug.Log("Stopppppppppp't");
        }
	}
}
