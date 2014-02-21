using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {

	GameObject pig;
	Vector3 defaultLocation;

	// Use this for initialization
	void Start () {
		pig = GameObject.FindGameObjectWithTag("Pig");
		defaultLocation = new Vector3(-100, -100, -100);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (pig.transform.position.x < -524) {

			transform.position = pig.transform.position;
			transform.position += new Vector3(0, 0, -5);

		} else {

			transform.position = defaultLocation;

		}

	}
}
