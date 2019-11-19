using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad3 : MonoBehaviour {

    public AudioSource pad3Sound;
    public GameObject obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //====================================================================
        // PAD0
        //====================================================================
        if (Input.GetKeyDown(KeyCode.D))
        {
            pad3Sound.Play();

            obj.GetComponent<Renderer>().material.color = Color.green;

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            obj.GetComponent<Renderer>().material.color = Color.black;
        }

    }
}
