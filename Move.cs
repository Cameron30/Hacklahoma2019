using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject obj;
    public bool tits;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y + .1f, obj.transform.position.z);

        if (Input.GetKey("left"))
        {
            obj.transform.eulerAngles = new Vector3(obj.transform.eulerAngles.x + .1f, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z);
        }

        if (Input.GetKey("right"))
        {
            obj.transform.eulerAngles = new Vector3(obj.transform.eulerAngles.x - .1f, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z);
        }
	}


    private void OnTriggerEnter(Collider other)
    {
        //other.transform.position
    }
}
