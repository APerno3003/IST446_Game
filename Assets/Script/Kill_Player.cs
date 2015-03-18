using UnityEngine;
using System.Collections;

public class Kill_Player : MonoBehaviour {

	void  OnCollisionEnter ( Collision theCollision  ){
		if(theCollision.gameObject.name == "Bad_Guy"  ){
			Destroy(theCollision.gameObject);
		}
	}
}
