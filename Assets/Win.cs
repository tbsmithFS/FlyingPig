using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {


	void OnGUI() {

		if (GUI.Button(new Rect(320, 160, 160, 70), "New Game")) {

			Application.LoadLevel(1);

		}

	}


	void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.LoadLevel(0); 

	}
}
