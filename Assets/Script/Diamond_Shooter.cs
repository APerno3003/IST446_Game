using UnityEngine;
using System.Collections;

public class Diamond_Shooter : MonoBehaviour
{

	// Use this for initialization
	GameObject prefab;
	string currentDirection = "Right";
	public bool canShoot = false;
	public int score = 0;
	private const int losePoints = 50;
	private Vector3 offset;

	void Start ()
	{
		prefab = Resources.Load ("Diamond") as GameObject;
		offset.Set(0.6F,0.0F,0.0F);
		displayScore ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			currentDirection = "Left";
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			currentDirection = "Right";
			
		}

		if (Input.GetKeyDown (KeyCode.Space) && canShoot && (score > 0)) {
			GameObject projectile = Instantiate (prefab) as GameObject;
			if (currentDirection == "Left") {
				projectile.transform.position = transform.localPosition - offset;//transform.position -Camera.main.transform.right;
				Rigidbody rb = projectile.GetComponent<Rigidbody> ();
				rb.velocity = Camera.main.transform.right * -10;
			} else {
				projectile.transform.position = transform.localPosition + offset; //transform.position + Camera.main.transform.right;
				Rigidbody rb = projectile.GetComponent<Rigidbody> ();
				rb.velocity = Camera.main.transform.right * 10;
			}
			Object.Destroy (projectile, 3.0f);
			score -= losePoints;
			displayScore();

		}
	}

	void  OnTriggerEnter (Collider theCollider)
	{
		if (theCollider.gameObject.name == "Collect_Diamond") {
			Destroy (theCollider.gameObject);
			canShoot = true;
		} 
	}

	void displayScore() {
		string scoreText = "Score: " + score;
		GUI.Box(new Rect (10,10,100,20),scoreText);
	}
}