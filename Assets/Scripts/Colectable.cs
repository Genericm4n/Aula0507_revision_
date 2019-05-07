using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectable : MonoBehaviour {

	void Start ()
    {	
	}
	
	void Update ()
    {
	}

    void OnCollisionEnter(Collision c)
    {
        if(c.collider.tag == "Player")
        {
            Player.points++;

            GameObject.Destroy(gameObject);
        }
    }
}
