using UnityEngine;
using System.Collections;

public class Destory_Self_Diamond : MonoBehaviour {
	//Tells Diamond to destory itself upon collision with all objects listed below
	void  OnCollisionEnter ( Collision theCollision  ){
		if (theCollision.gameObject.name == "Player" /*|| theCollision.gameObject.name == "Door" */
			|| theCollision.gameObject.name == "Wall"|| theCollision.gameObject.name == "Floor" 
		    || theCollision.gameObject.name == "Diamond"|| theCollision.gameObject.name == "Diamond(Clone)"
		    || theCollision.gameObject.name == "Moving_Floor") {

			Destroy (gameObject);
		} 

		else if (theCollision.gameObject.name == "Bad_Guy" || theCollision.gameObject.name == "Bad_Guy_Shoots"
		         || theCollision.gameObject.name == "Bad_Guy_Moves"|| theCollision.gameObject.name == "Bad_Guy_Moves_Shoots") {

			Destroy(theCollision.gameObject);
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter( Collider theCollider)
	{
		if (theCollider.gameObject.name == "Spike" || theCollider.gameObject.name == "Door"
		    || theCollider.gameObject.name == "Collect_Diamond") {
			Destroy(gameObject);
		}
	}



}
