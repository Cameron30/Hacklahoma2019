﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);

        if (transform.position.x < -100)
        {
            Destroy(this);
        }
	}
}
