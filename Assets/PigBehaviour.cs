using UnityEngine;
using System.Collections;

public class PigBehaviour : MonoBehaviour {

	Sprite pig_wings_up;
	Sprite pig_wings_down;

	enum Facing {Left, Right}
	Facing facing = Facing.Right;

	float gravityBoost = 2000.0f;
	float jumpForceBoost = 1.0f;

	Vector3 jumpRightVector = new Vector3(3000, 7500, 0);
	Vector3 jumpLeftVector = new Vector3(-3000, 7500, 0);
	Vector3 down = new Vector3(0, -1, 0);

	// Use this for initialization
	void Start () {
	
		pig_wings_up = Resources.Load<Sprite>("pig_wings_up");
		pig_wings_down = Resources.Load<Sprite>("pig_wings_down");

		if (pig_wings_up == null) {
			Debug.Log ("is null");
		}

	}

	// Update is called once per frame
	void FixedUpdate () {

		rigidbody.AddForce(gravityBoost * down);

		if (Input.touchCount > 0) {

			if (Input.GetTouch(0).position.x > Screen.width/2) {

				rigidbody.AddForce(jumpForceBoost * jumpRightVector);

				if (facing == Facing.Left) {
					transform.localScale = 

						new Vector3(

							transform.localScale.x * -1,
							transform.localScale.y,
							transform.localScale.z


							)

							;
					facing = Facing.Right;
				}

			} else { 

				rigidbody.AddForce(jumpForceBoost * jumpLeftVector);

				if (facing == Facing.Right) {
					transform.localScale = 
						
						new Vector3(
							
							transform.localScale.x * -1,
							transform.localScale.y,
							transform.localScale.z
							
							
							)
							
							;
					facing = Facing.Left;
				}

			}

			gameObject.GetComponent<SpriteRenderer>().sprite = pig_wings_down;

		} else {

			gameObject.GetComponent<SpriteRenderer>().sprite = pig_wings_up;
		
		}





		if (Input.GetKeyDown(KeyCode.Escape)) {
			Debug.Log("Escape key in pig behaviour");
			Application.LoadLevel(0); 
		}
		
	}
}
