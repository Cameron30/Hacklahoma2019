using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad1 : MonoBehaviour {
    public Material Material1;
    public Material Material2;
    public AudioSource pad1Sound;
    public GameObject obj;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //====================================================================
        // PAD1
        //====================================================================
        if (Input.GetKeyDown(KeyCode.A))
        {
            pad1Sound.Play();
            obj.GetComponent<MeshRenderer>().material = Material1;

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            obj.GetComponent<MeshRenderer>().material = Material2;
        }
    }
}
