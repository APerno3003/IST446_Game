using UnityEngine;
using System.Collections;

public class Door_Collision : MonoBehaviour {
	public string scene;


	/*void  OnCollisionEnter ( Collision theCollision  ){
		if(theCollision.gameObject.name == "Player"){
			Application.LoadLevel(scene);
		}
	}*/

	void  OnTriggerEnter ( Collider theCollider  ){
		if(theCollider.gameObject.name == "Player"){
			Application.LoadLevel(scene);
		}
	}

}
