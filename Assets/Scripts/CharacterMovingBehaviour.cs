using UnityEngine;

public class CharacterMovingBehaviour : MonoBehaviour 
{

    CharacterController characterController;
    public float turnSpeed = 5.0f;
    public float moveSpeed = 5.0f;

	void Start()
	{
	    characterController = GetComponent<CharacterController>();
	}

	void Update()
	{
		var horizontalInput = Input.GetAxis("Horizontal");
		var verticalInput = Input.GetAxis("Vertical");

        var rotation = new Vector3(0.0f, horizontalInput * turnSpeed, 0.0f);
        var velocity = transform.forward * verticalInput * moveSpeed;

        transform.Rotate(rotation);
		characterController.SimpleMove(velocity);
	}
}
