using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class mazeDuino : MonoBehaviour
{

    SerialPort serial = new SerialPort("COM8", 115200); //COM5 on the desktop, COM7 on Cameron's laptop....
    public float x;
    public float y;
    public float z;
    Quaternion kumQuat;

    float qW, qX, qY, qZ;

    bool flag;

    // Use this for initialization
    void Start()
    {
        serial.ReadTimeout = 2000;
        if (!serial.IsOpen) serial.Open();

        StartCoroutine(updateArduino());

        serial.Write("w");
        qW = float.Parse(serial.ReadLine());
        qX = float.Parse(serial.ReadLine());
        qY = float.Parse(serial.ReadLine());
        qZ = float.Parse(serial.ReadLine());

        kumQuat = new Quaternion(qX, qY, qZ, qW);
        var vec = kumQuat.eulerAngles;
        x = vec.x;
        y = vec.y;
        z = vec.z;
    }

    IEnumerator updateArduino()
    {
        serial.ReadTimeout = 2000;
        while (true)
        {
            var oldX = 0f;
            var oldZ = 0f;

            flag = false;
            yield return new WaitForSeconds(Time.deltaTime);

            if (!flag)
            {
                //Debug.Log("Start of coroutine");
                //if (!serial.IsOpen) serial.Open();
                serial.Write("w");
                qW = float.Parse(serial.ReadLine());
                qX = float.Parse(serial.ReadLine());
                qY = float.Parse(serial.ReadLine());
                qZ = float.Parse(serial.ReadLine());
                /*
                serial.Write("1");
                float aX = float.Parse(serial.ReadLine());
                serial.Write("2");
                float aY = float.Parse(serial.ReadLine());
                serial.Write("3");
                float aZ = float.Parse(serial.ReadLine());
                */

                kumQuat = new Quaternion(qX, qY, qZ, qW);
                var vec = kumQuat.eulerAngles;


                //if (delX > .25f) delX = 0.25f; // make sure no value exceeds 0.25 (ball safety)
                //if (delY > .25f) delY = 0.25f;
                //if (delZ > .25f) delZ = 0.25f;

                var newX = -vec.y; //positions to be assigned to maze.
                var newZ = vec.x;

                if (newX > 45 && newX < 180) newX = 45;
                if (newZ > 45 && newZ < 180) newZ = 45;

                if (newX < -45 && newX > -180) newX = -45;
                if (newZ < -45 && newZ > -180) newZ = -45;

                transform.eulerAngles = new Vector3(newX,0,newZ);
                oldX = newX;
                oldZ = newZ;
            }
            flag = true;
        }
    }
}