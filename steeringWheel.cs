using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steeringWheel : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("left"))
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + .2f, transform.localEulerAngles.z);
        }

        if (Input.GetKey("right"))
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y - .2f, transform.localEulerAngles.z);
        }
    }
}
