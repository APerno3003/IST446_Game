using UnityEngine;
using System.Collections;

public class Bad_Guy_Moves_and_Shoots : MonoBehaviour {

	GameObject prefab;
	private Vector3 offset;
	public string currentDirection = "Right";
	
	public float counter = 0; 
	public float seconds = 10;

	private Vector3 velocity;
	private Transform _transform;
	public float distance;
	public float speed;
	private Vector3 _originalPosition;
	public bool isGoingLeft;

	// Use this for initialization
	void Start () {
		//records the initial position of the object
		_originalPosition = gameObject.transform.position;
		
		_transform = GetComponent<Transform>();
		
		//sets the speed the object will move in the x direction
		velocity = new Vector3(speed,0,0);
		//start first movement
		_transform.Translate ( velocity.x*Time.deltaTime,0,0);

		prefab = Resources.Load ("Bullet") as GameObject;
		offset.Set(0.5F,0.0F,0.0F);
	}
	
	// Update is called once per frame
	void Update() {
	
		//determines how far from the intial position the current object is
		float distFromStart = transform.position.x - _originalPosition.x;   
	
		waitThenShoot();

		if (isGoingLeft) { 
			// If gone too far, switch direction
			currentDirection = "Left";
			if (distFromStart < -distance) {
				isGoingLeft = false;
			}
			_transform.Translate (-velocity.x * Time.deltaTime, 0, 0);
		} else {
			// If gone too far, switch direction
			currentDirection = "Right";
			if (distFromStart > distance) {
				isGoingLeft = true;
			}
		
			_transform.Translate (velocity.x * Time.deltaTime, 0, 0);
		}
	}

	void shoot() {
		GameObject projectile = Instantiate (prefab) as GameObject;
		if (currentDirection == "Left") {
			projectile.transform.position = transform.localPosition - offset;
			Rigidbody rb = projectile.GetComponent<Rigidbody> ();
			rb.velocity = Camera.main.transform.right * -10;
		} else {
			projectile.transform.position = transform.localPosition + offset;
			Rigidbody rb = projectile.GetComponent<Rigidbody> ();
			rb.velocity = Camera.main.transform.right * 10;
			
		}
		Object.Destroy (projectile, 3.0f);
	}
	
	//calls shoot function if counter >= seconds and then resests counter
	void waitThenShoot(){
		if (counter >= seconds) {
			counter = 0;
			shoot ();
		} else {
			counter += Time.deltaTime;
		}

}
}
