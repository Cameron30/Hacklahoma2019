using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Arduino : MonoBehaviour
{

    SerialPort serial = new SerialPort("COM8", 115200);
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
                //Debug.Log(vec);


                vec = new Vector3(0, (vec.z - z) * -1, 0);
                transform.localEulerAngles = vec;
            }
            flag = true;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        /*
        if (!serial.IsOpen) serial.Open();
        serial.Write("wxyz");
        float qW = float.Parse(serial.ReadLine());
        float qX = float.Parse(serial.ReadLine());
        float qY = float.Parse(serial.ReadLine());
        float qZ = float.Parse(serial.ReadLine());

        serial.Write("1");
        float aX = float.Parse(serial.ReadLine());
        serial.Write("2");
        float aY = float.Parse(serial.ReadLine());
        serial.Write("3");
        float aZ = float.Parse(serial.ReadLine());



        kumQuat = new Quaternion(qX, qY, qZ, qW);
        var vec = kumQuat.eulerAngles;
        //Debug.Log(vec);


        vec = new Vector3(0, (vec.z - z) * -1, 0);
        transform.localEulerAngles = vec;
        //  */
    }
}