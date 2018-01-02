using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour {

    // Use this for initialization

    public float speed = 10.0f;

	void Start () {
        Cursor.lockState = CursorLockMode.Locked; //Turn off the mouse cursor.
	}
	
	// Update is called once per frame
	void Update () {
        float forwardbackwardmovement = Input.GetAxis("Vertical") * speed;
        float leftrightmovement = Input.GetAxis("Horizontal") * speed;
        forwardbackwardmovement *= Time.deltaTime;
        leftrightmovement *= Time.deltaTime;
        transform.Translate(leftrightmovement, 0, forwardbackwardmovement);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;





    }
}
