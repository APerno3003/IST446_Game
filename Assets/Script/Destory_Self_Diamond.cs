using UnityEngine;
using System.Collections;

public class Destory_Self_Diamond : MonoBehaviour {
	//Tells Diamond to destory itself upon collision with all objects listed below
	void  OnCollisionEnter ( Collision theCollision  ){
		if(theCollision.gameObject.name == "Player" || theCollision.gameObject.name == "Door" 
		   || theCollision.gameObject.name == "Wall"  /*|| theCollision.gameObject.name == "Bad_Guy"*/ 
		   || theCollision.gameObject.name == "Floor" || theCollision.gameObject.name == "Diamond"  ){
			Destroy(gameObject);
		}
	}

}
