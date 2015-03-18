using UnityEngine;
using System.Collections;

public class Door_Collision : MonoBehaviour {
	public string scene;

	//commented out code is applied to player to say if player has a collision with door change scene
	/*void  OnCollisionEnter ( Collision theCollision  ){
		if(theCollision.gameObject.name == "Door"){
			Application.LoadLevel(scene);
		}
	}*/



	void  OnCollisionEnter ( Collision theCollision  ){
		if(theCollision.gameObject.name == "Player"){
			Application.LoadLevel(scene);
		}
	}

}
