using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	public Transform[] target;
	public float speed;

	private int current;


	void Update () {
		if (transform.position != target[current].position) {  //if not at current position
			
			Vector3 pos = Vector3.MoveTowards(transform.position,target[current].position,speed * Time.deltaTime);  // setup pos
            Debug.Log("pos: " + pos); //show me pos.
			GetComponent<Rigidbody>().MovePosition(pos);
            Debug.Log("current: " + current); //show me current.
        } else current = (current + 1) % target.Length; // waypoint reached, move to next object 
            Debug.Log("current: " + current); //show me current.

    }
}
