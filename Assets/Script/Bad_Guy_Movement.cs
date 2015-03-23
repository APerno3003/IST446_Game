using UnityEngine;
using System.Collections;

public class Bad_Guy_Movement : MonoBehaviour {

	private Vector3 velocity;
	private Transform _transform;
	public float distance;
	public float speed;
	public Vector3 _originalPosition;
	public bool isGoingLeft;

	void Start () {
		_originalPosition = gameObject.transform.position;
		_transform = GetComponent<Transform>();
		velocity = new Vector3(speed,0,0);
		_transform.Translate ( velocity.x*Time.deltaTime,0,0);
	}

	// Update is called once per frame
	void Update () {
		//keeps badguy on the 0 z plane
		transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
		transform.position = (new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 0));

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