using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	float spinSpeed = 80;
	GameObject coinSound;

	// Use this for initialization
	void Start () {
		coinSound = GameObject.FindGameObjectWithTag("CoinSound");
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody.transform.RotateAround(transform.position, transform.up, spinSpeed * Time.deltaTime);

	}


	void OnTriggerEnter(Collider obj) {

		if (obj.tag == "Pig") {

			coinSound.audio.Play();

			Destroy(transform.parent.gameObject);

			Score.score += 1;


		}

	}


}
