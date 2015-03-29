using UnityEngine;
using System.Collections;

public class Bad_Guy_Shoots : MonoBehaviour {
	
	// Use this for initialization
	GameObject prefab;
	private Vector3 offset;
	public string currentDirection = "Right";

	public float counter = 0; 
	public float seconds = 10;


	void Start () {
		prefab = Resources.Load ("Bullet") as GameObject;
		offset.Set(0.5F,0.0F,0.0F);
	}
	
	// Update is called once per frame
	void Update () {
		//calls waitThenShoots every frame
		waitThenShoot ();
	}

	void shoot() {
			GameObject projectile = Instantiate (prefab) as GameObject;
			if (currentDirection == "Left") {
				projectile.transform.position = transform.localPosition - offset;//transform.position + -(Camera.main.transform.right);
				Rigidbody rb = projectile.GetComponent<Rigidbody> ();
				rb.velocity = Camera.main.transform.right * -10;
			} else {
				projectile.transform.position = transform.localPosition + offset;//transform.position + Camera.main.transform.right;
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
