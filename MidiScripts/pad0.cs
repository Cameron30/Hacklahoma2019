using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad0 : MonoBehaviour {

    public AudioSource pad0Sound;
    public GameObject obj;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
            //====================================================================
            // PAD0
            //====================================================================
            if (Input.GetKeyDown(KeyCode.W))
            {
                pad0Sound.Play();

                obj.GetComponent<Renderer>().material.color = Color.red;

            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                obj.GetComponent<Renderer>().material.color = Color.black;
            }
        }

       
  
   }
