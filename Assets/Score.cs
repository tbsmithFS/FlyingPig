using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	GUIStyle style;
	public static float score = 0;

	void Start() {
		style = new GUIStyle();
		style.fontSize = 30;
		style.normal.textColor = Color.green;
		score = 0;
	}

	void OnGUI() {

		GUI.BeginGroup(new Rect(50, 50, 200, 50));
		GUI.Box(new Rect(0, 0, 200, 50), "");
		GUI.Label(new Rect(10, 10, 200, 50), "Score: " + score, style);
		GUI.EndGroup();


	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Score.score = 0;
			Application.LoadLevel(0); 
		}
	}


}
