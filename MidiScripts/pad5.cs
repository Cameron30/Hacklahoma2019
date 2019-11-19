using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad5 : MonoBehaviour {
    public Material Material1;
    public Material Material2;

    public AudioSource pad5Sound;
    public GameObject obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //====================================================================
        // PAD5
        //====================================================================
        if (Input.GetKeyDown(KeyCode.G))
        {
            pad5Sound.Play();

            obj.GetComponent<MeshRenderer>().material = Material1;

        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            obj.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
