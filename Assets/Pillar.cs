using UnityEngine;
using System.Collections;

public class Pillar : MonoBehaviour {

	public bool passed;
	GameObject nextPillar;
	GameObject pig;
	float spinSpeed;

	// Use this for initialization
	void Start () {
		passed = false;
		pig = GameObject.FindGameObjectWithTag("Pig");
		spinSpeed = Random.Range(-180, 180);
	}
	
	// Update is called once per frame
	void Update () {

		if (pig.transform.position.x > transform.position.x && passed == false) {
			
			passed = true;
			Score.score += 1;
			
			nextPillar = 
				
				(GameObject) Object.Instantiate(
					GameObject.FindGameObjectWithTag("OriginalPillar"));

			nextPillar.tag = "Pillar";
			
			nextPillar.transform.position = 
				
				new Vector3(
					
					transform.position.x + 10,
					
					Random.Range(10,30),
					
					transform.position.z
					
					);


			for (int i=0; i<4; i++) {

				Debug.Log ("here "+i);

				GameObject coinContainer = (GameObject) Object.Instantiate(GameObject.FindGameObjectWithTag("OriginalCoinContainer"));
				coinContainer.tag = "CoinContainer";
				coinContainer.transform.position = new Vector3( 
				                                      
				                                      transform.position.x + Random.Range(12, 18),
				                                      Random.Range(2,39),
				                                      0.5f
				                                      
				                                      );

				Debug.Log ("put at: " + coinContainer.transform.position);
				Debug.Log ("pig at: " + pig.transform.position);

			}
			

			
		}

	}
}
