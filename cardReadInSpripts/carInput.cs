using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carInput : MonoBehaviour {
    Text text;
    InputField cardNum;
    public Material Material1;
    public Material Material2;

    public AudioSource pad5Sound;
    public GameObject obj;
    void Start()
    {
        cardNum = text.GetComponent<InputField>();
    }

    void Update()
    {
       
        if(cardNum.Equals("Ass"))
        {
            obj.GetComponent<MeshRenderer>().material = Material1;
        }
        
    }
}
