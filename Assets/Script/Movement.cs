using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	public float moveSpeed = 6.0F;
	//public float jumpSpeed = 2.0F;
	//public float gravity = 20.0F;
	public bool onGround = true; // start off true so no auto jump

	public float jump_height = 0.0F;
	public const float MAX_JUMP_HEIGHT = 25.0F;
	public const float JUMP_DELTA = 1.0F;
	public const float SMALL_JUMP = 2.0F;
	public const float JUMP_SPEED = 8.0F;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		// 1.)
		// reset rotation every frame, so object's rotation is not affected by jump
		// fixes falling off platform bug
		transform.rotation = Quaternion.Euler(new Vector3(0,0,0));

		// Resets z-position of player every frame, so it cannot fall off platform
		transform.position = (new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 0));

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector3 (-moveSpeed, 0, 0) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector3 (moveSpeed, 0, 0) * Time.deltaTime);

		}


		if (onGround && (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow))) {

			// non-smooth jump
			//transform.Translate (new Vector3 (0, jumpSpeed * 15, 0) * Time.deltaTime, Space.World);

			// 2.)
			// smooth jump 
			// jumps enough to get object off ground(set onGround to false), and update loop() will do the rest of the jump
			transform.Translate (new Vector3 (0, SMALL_JUMP, 0) * Time.deltaTime, Space.World);
		}

		// 3.)
		// Object is in the middle of jumping, keep going up until max height is reached
		if (!onGround && jump_height < MAX_JUMP_HEIGHT && (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)))
		{
			transform.Translate(new Vector3 (0, JUMP_SPEED, 0) * Time.deltaTime, Space.World);
			jump_height += JUMP_DELTA;
		}

		//print (jump_height);
	}
	
	void  OnCollisionEnter (Collision theCollision)
	{
		if (theCollision.gameObject.name == "Floor") {
			// 4.) upon hitting ground, reset jump height for next jump
			onGround = true; 
			jump_height = 0.0F;
		}
	}

	void  OnCollisionExit ( Collision theCollision  ){
		if(theCollision.gameObject.name == "Floor"){
			onGround = false;
		}
	}



}