using UnityEngine;
using System.Collections;

public class Bullet_Destory_Self : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void  OnCollisionEnter ( Collision theCollision  ){
		if (theCollision.gameObject.name == "Bad_Guy" || theCollision.gameObject.name == "Door" 
		    || theCollision.gameObject.name == "Wall"  || theCollision.gameObject.name == "Bullet" 
		    || theCollision.gameObject.name == "Floor") {
			
			Destroy (gameObject);
		} 
		
		else if (theCollision.gameObject.name == "Player" || theCollision.gameObject.name == "Diamond(Clone)" || theCollision.gameObject.name == "Diamond") {
			
			Destroy(theCollision.gameObject);
			Destroy(gameObject);
		}

	}

}
