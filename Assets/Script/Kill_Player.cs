using UnityEngine;
using System.Collections;

public class Kill_Player : MonoBehaviour {

	void  OnCollisionEnter ( Collision theCollision  ){
		if (theCollision.gameObject.name == "Bad_Guy" || theCollision.gameObject.name == "Bad_Guy_Moves"
		    || theCollision.gameObject.name == "Bad_Guy_Shoots" || theCollision.gameObject.name == "Bad_Guy_Moves_Shoots" ) {
			Destroy (gameObject);
			Application.LoadLevel(Application.loadedLevelName);
		} else if (theCollision.gameObject.name == "Bullet" || theCollision.gameObject.name == "Bullet(Clone)") {
			Destroy (gameObject);
			Destroy(theCollision.gameObject);
			Application.LoadLevel(Application.loadedLevelName);
		}
	}
	void OnTriggerEnter( Collider theCollision)
	{
		if (theCollision.gameObject.name == "Spike") {
			Destroy(gameObject);
			Application.LoadLevel(Application.loadedLevelName);
		}
	}

}
