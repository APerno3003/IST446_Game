using UnityEngine;
using System.Collections;

public class Level_Timer : MonoBehaviour {

	private float levelTime = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		levelTime += Time.deltaTime;
	}

	void OnGUI() {
		string levelTimeText = "Time: " + levelTime;
		GUI.Box(new Rect (10,30,100,20), levelTimeText);
	}
}
