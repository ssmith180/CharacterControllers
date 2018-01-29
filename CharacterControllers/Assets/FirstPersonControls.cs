using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonControls : MonoBehaviour {

    public float speed = 4.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            //moveDirection += new Vector3(0, 0, 1);

            moveDirection += transform.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += -transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += -transform.right;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += transform.right;
        }

        transform.position += moveDirection.normalized * speed * Time.deltaTime;

	}
}
