using UnityEngine;
using System.Collections;

public class Bullet_Destory_Self : MonoBehaviour {


	void  OnCollisionEnter ( Collision theCollision  ){
		if (theCollision.gameObject.name == "Bad_Guy" || theCollision.gameObject.name == "Bad_Guy_Shoots"
		    || theCollision.gameObject.name == "Bad_Guy_Moves" || theCollision.gameObject.name == "Door" 
		    || theCollision.gameObject.name == "Wall"  || theCollision.gameObject.name == "Bullet" 
		    || theCollision.gameObject.name == "Bullet(Clone)" || theCollision.gameObject.name == "Floor" 
		    || theCollision.gameObject.name == "Collect_Diamond") {
			
			Destroy (gameObject);
		} 
		
		else if (/*theCollision.gameObject.name == "Player" ||*/ theCollision.gameObject.name == "Diamond(Clone)" || theCollision.gameObject.name == "Diamond") {
			
			Destroy(theCollision.gameObject);
			Destroy(gameObject);
		}

	}

}
