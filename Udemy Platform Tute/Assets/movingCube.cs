using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingCube : MonoBehaviour
{

    [SerializeField] private float objectSpeed = 1f;
    private float resetPosition = 0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    transform.Translate(Vector3.right * (objectSpeed * Time.deltaTime));


	   if (transform.localPosition.x <= resetPosition)
	    {
	        Vector3 newPos = new Vector3(5f, transform.position.y, transform.position.z);
	        transform.position = newPos;
	    }


	}
}
