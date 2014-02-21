using UnityEngine;
using System.Collections;

public class PillarControl : MonoBehaviour {

	GameObject pig;
	GameObject[] coins;
	GameObject originalPillar;

	// Use this for initialization
	void Start () {
		pig = GameObject.FindGameObjectWithTag("Pig");
		originalPillar = GameObject.FindGameObjectWithTag("OriginalPillar");
	}
	
	// Update is called once per frame
	void Update () {

		if (pig.transform.position.x > -30) {

		
			pig.transform.position = new Vector3(

				-523,
				pig.transform.position.y,
				pig.transform.position.z

				);



			foreach( GameObject go in GameObject.FindGameObjectsWithTag("Pillar") ) {

				if (go.transform.position.x > -490) {
					Object.Destroy(go);
				}

			}

			foreach( GameObject go in GameObject.FindGameObjectsWithTag("CoinContainer") ) {
				Object.Destroy(go);
			}



		}

		// Remove passed pillars
		foreach( GameObject go in GameObject.FindGameObjectsWithTag("Pillar") ) {
			
			if (go.transform.position.x < pig.transform.position.x - 30) {
				Debug.Log ("go: " + go.transform.position + " pig: " + pig.transform.position);
				Object.Destroy(go);
			}
			
		}

		// Remove passed coins
		foreach( GameObject go in GameObject.FindGameObjectsWithTag("CoinContainer") ) {
			
			if (go.transform.position.x < pig.transform.position.x - 30) {
				Object.Destroy(go);
			}
			
		}





	}
}
