using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad2 : MonoBehaviour {
    public AudioSource pad2Sound;
    public GameObject obj;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //====================================================================
        // PAD2
        //====================================================================
        if (Input.GetKeyDown(KeyCode.S))
        {
            pad2Sound.Play();

            obj.GetComponent<Renderer>().material.color = Color.yellow;

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            obj.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
