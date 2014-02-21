using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	float oldScore;
	GUIStyle style;
	GUIStyle buttonStyle;

	void Start() {

		oldScore = Score.score;
		style = new GUIStyle();
		buttonStyle = new GUIStyle();
		Score.score = 0;

	}

	void OnGUI() {

		style.fontSize = 80;
		style.fontStyle = FontStyle.Bold;

		GUI.Label(new Rect(Screen.width/2.0f-50, 40, 160, 70), "Score: " + oldScore, style);

	}


	void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Debug.Log("Escape key in game over");
			Application.LoadLevel(0); 
		}

	}
}
