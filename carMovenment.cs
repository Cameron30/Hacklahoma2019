using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovenment : MonoBehaviour
{
    public GameObject wheel;
    public float newZ;
    // Use this for initialization
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        var turn = wheel.transform.eulerAngles.y;
        newZ = transform.position.z;

        if (newZ > 6.25) newZ = -7.5f; // right wall
        if (newZ < -19.5) newZ = -7.5f; // left wall

        if (turn > 0 && turn < 180) //arduino reading a right turn (90deg is max rightness)
        {
            
            turn = wheel.transform.eulerAngles.y;
            turn = Mathf.Abs((turn - 90) / 90);
            turn = 1 - turn;
            //Debug.Log(turn);
            newZ = newZ - turn*.3f;

        }

        if (turn > 180 && turn < 360) //arduino reading a left turn (270 is max leftness)
        {
            
            turn = wheel.transform.eulerAngles.y;
            turn = Mathf.Abs((turn - 270) / 270);
            turn = 1 - turn;
            //Debug.Log(turn);
            newZ = newZ + turn*.3f;

        }
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ); //only set a new Z coord.

       // Debug.Log(newZ);
    }
}
