using UnityEngine;
using System.Collections;

public class Button_Scene_Change : MonoBehaviour {
		
		public void ChangeToScene (string sceneToChangeTo) {
			Application.LoadLevel(sceneToChangeTo);
		}


}
