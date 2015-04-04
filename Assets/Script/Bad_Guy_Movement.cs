using UnityEngine;
using System.Collections;

public class Bad_Guy_Movement : MonoBehaviour {

	private Vector3 velocity;
	private Transform _transform;
	public float distance;
	public float speed;
	private Vector3 _originalPosition;
	public bool isGoingLeft;

	void Start () {
		//records the initial position of the object
		_originalPosition = gameObject.transform.position;

		_transform = GetComponent<Transform>();

		//sets the speed the object will move in the x direction
		velocity = new Vector3(speed,0,0);
		//start first movement
		_transform.Translate ( velocity.x*Time.deltaTime,0,0);
	}

	// Update is called once per frame
	void Update () {

		//determines how far from the intial position the current object is
		float distFromStart = transform.position.x - _originalPosition.x;   

		if (isGoingLeft)
		{ 
			// If gone too far, switch direction
			if (distFromStart < -distance)
			{
				isGoingLeft = false;
			}
			_transform.Translate (-velocity.x * Time.deltaTime, 0, 0);
		}
		else
		{
			// If gone too far, switch direction
			if (distFromStart > distance)
			{
				isGoingLeft = true;
			}
			
			_transform.Translate (velocity.x * Time.deltaTime, 0, 0);
		}
	}

}