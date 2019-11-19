using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

    static System.Random rnd = new System.Random();
    int difficultyScalar = 2;

    bool flag;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnObstacle());
    }


    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            if (flag)
            {
                var instance = (GameObject)Instantiate(Resources.Load("Obstacle1"));
                var rndInt = rnd.Next(1, 6);
                instance.transform.position = new Vector3(500, 0, -15 + (rndInt * 5));
            }

            flag = false;
            yield return new WaitForSeconds(1);
            flag = true;
        }
        
    }

    // Update is called once per frame
    void Update () {
    }
}
