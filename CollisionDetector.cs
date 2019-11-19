using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {


    public float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Ground"))
        {
            time += Time.deltaTime;
        }
        
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Obstacle1(Clone)")
        {
            Destroy(GameObject.Find("Ground"));

            var obstacles = GameObject.FindGameObjectsWithTag("Obstacle");

            foreach (var obstacle in obstacles)
            {
                Destroy(obstacle);
            }

            var black = (GameObject)Instantiate(Resources.Load("Black"));
        }


    }
}
