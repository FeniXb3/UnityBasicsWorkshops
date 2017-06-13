using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour {

    Rigidbody capsuleRb;
    public float speedMultiplier = 1;

	// Use this for initialization
	void Start () {
        capsuleRb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementVector = new Vector3(horizontalInput, 0.0f, verticalInput);

        capsuleRb.AddForce(movementVector * speedMultiplier);
	}
}
