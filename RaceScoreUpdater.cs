using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaceScoreUpdater : MonoBehaviour {

    float time;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();

        var par = transform.parent;
        var colDet = par.GetComponent<CollisionDetector>();
        time = colDet.time;

        textmeshPro.text = "Time: " + (int)time;
    }
}
