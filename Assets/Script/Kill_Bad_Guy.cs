using UnityEngine;
using System.Collections;

public class Kill_Bad_Guy : MonoBehaviour {

	//Tells Bad_Guy to destory itself upon collision with all objects listed below
	void  OnCollisionEnter ( Collision theCollision  ){
		if(theCollision.gameObject.name == "Diamond"  ){
			//Debug.Log("bad guy hit");
			//Destroy(theCollision.gameObject);
			Destroy(gameObject);

		}
	}
}

