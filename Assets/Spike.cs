using UnityEngine;
using System.Collections;

public class Spike : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider obj) {

		if (obj.tag == "Pig") {
		
			Destroy(obj);

			Application.LoadLevel(2);
		
		}

	}


}
