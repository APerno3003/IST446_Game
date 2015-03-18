using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	public float moveSpeed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	public bool onGround = false;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector3 (-moveSpeed, 0, 0) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector3 (moveSpeed, 0, 0) * Time.deltaTime);

		}


		if (onGround && (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow))) {
			//transform.Translate (new Vector3 (0, moveSpeed, 0) * Time.deltaTime);
			transform.Translate (Vector3.up * jumpSpeed* Time.deltaTime, Space.World);
			//transform.Translate (Vector3.up * jumpSpeed * Time.deltaTime, Space.World);
			//transform.Translate(Vector2.up * 100 * Time.deltaTime, Space.World);
		}
		/*if (Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow)) {
						transform.Translate (new Vector3 (0, -moveSpeed, 0) * Time.deltaTime);
			
		}*/

	}

	void  OnCollisionEnter (Collision theCollision)
	{
		if (theCollision.gameObject.name == "Floor") {
			onGround = true;
		}
	}

	void  OnCollisionExit ( Collision theCollision  ){
		if(theCollision.gameObject.name == "Floor"){
			onGround = false;
		}
	}



}