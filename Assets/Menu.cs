using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	GUIStyle buttonStyle = new GUIStyle();

	void OnGUI() {

		buttonStyle.fontSize = 80;
		
		if (GUI.Button(new Rect(Screen.width/2.0f-50, 
		                        Screen.height/2.0f, 
		                        Screen.width/4.0f, 
		                        Screen.height/5.0f), 
		               "Play"
		               
		               )) {
			Score.score = 0;
			Application.LoadLevel(1);
			
		}

	}


}
