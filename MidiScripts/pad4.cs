using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad4 : MonoBehaviour {

    public AudioSource pad4Sound;
    public GameObject obj;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //====================================================================
        // PAD4
        //====================================================================
        if (Input.GetKeyDown(KeyCode.F))
        {
            pad4Sound.Play();

            obj.GetComponent<Renderer>().material.color = Color.blue;

        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            obj.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
