using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public void GetInput(string guess)
    {
        Debug.Log("top of game controller");
        // Road Rage
        if(guess.Equals("%6010=2817661187581937033?;6010=0000000021207343?"))
        {
            Debug.Log("SHIT");
            var instance = (GameObject)Instantiate(Resources.Load("Maze"));

            var other = GameObject.Find("Race");

            if (other == null)
            {
                other = GameObject.Find("DJ");
            }

            if (other != null)
            {
                Destroy(other);
            }
        }
        // Da MAzE
        else if(guess.Equals(";6010568706295939=25010004000060145670?") || 
            guess.Equals("%B6010568706295939^WALMARTSHOPCARD^25010004000060145670           ?;6010568706295939=25010004000060145670? ")) {
            Debug.Log("Maze Bitch");
            var instance = (GameObject)Instantiate(Resources.Load("Race"));

            var other = GameObject.Find("Maze");

            if (other == null)
            {
                other = GameObject.Find("DJ");
            }

            if (other != null)
            {
                Destroy(other);
            }
        }
        // MiDi Cuz
        else if (guess.Equals("%B6010568706284099^WALMARTSHOPCARD^25010004000060146201           ?;6010568706284099=25010004000060146201?"))
        {
            Debug.Log("Midi cuz");
            var instance = (GameObject)Instantiate(Resources.Load("DJ"));

            var other = GameObject.Find("Maze");

            if (other == null)
            {
                other = GameObject.Find("Race");
            }

            if (other != null)
            {
                Destroy(other);
            }
        }

        Destroy(transform.parent.gameObject);
    }
    
}
