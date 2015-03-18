using UnityEngine;
using System.Collections;

public class Diamond_Shooter : MonoBehaviour {

	// Use this for initialization
	GameObject prefab;
	string currentDirection = "Right";
	void Start () {
		prefab = Resources.Load ("Diamond") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			currentDirection = "Left";
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			currentDirection = "Right";
			
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject projectile = Instantiate(prefab) as GameObject;
			if(currentDirection == "Left")
			{
				projectile.transform.position = transform.position + -(Camera.main.transform.right);
				Rigidbody rb = projectile.GetComponent<Rigidbody>();
				rb.velocity = Camera.main.transform.right*-10;
			}
			else
			{
			projectile.transform.position = transform.position + Camera.main.transform.right;
			Rigidbody rb = projectile.GetComponent<Rigidbody>();
			rb.velocity = Camera.main.transform.right*10;
			}
			Object.Destroy(projectile, 3.0f);

		}
	}
}
