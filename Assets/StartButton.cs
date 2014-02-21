using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour
{

		BoxCollider2D myCollider;
		Vector3 worldTouchPosition;
		Vector2 worldTouchPosition2d;
		Sprite greybutton;
		Sprite greenbutton;

		// Use this for initialization
		void Start ()
		{
				myCollider = gameObject.GetComponent<BoxCollider2D> ();
				greybutton = gameObject.GetComponent<SpriteRenderer> ().sprite;
				greenbutton = Resources.Load<Sprite> ("startbuttongreen");
		}
	
		// Update is called once per frame
		void Update ()
		{

				Score.score = 0;

				// if there is at least one touch and it's a touch-down event
				if ((Input.touchCount > 0)) {

						Touch touch = Input.GetTouch (0);


			
						// change screen touch coords to 3d Unity world coords
						worldTouchPosition = Camera.main.ScreenToWorldPoint (
				touch.position
						);
			
						// chop it down to just 2d
						worldTouchPosition2d = new Vector2 (worldTouchPosition.x, 
			                                   worldTouchPosition.y);
			
						// This script is attached to each tile, so it will run on each
						// tile. Here each tile is checking to see if it's the one that
						// was touched.
						if (myCollider == Physics2D.OverlapPoint (worldTouchPosition2d)) {

								if (touch.phase == TouchPhase.Began) {

										gameObject.GetComponent<SpriteRenderer> ()
											.sprite = greenbutton;

								} else if (touch.phase == TouchPhase.Ended) {
				
										gameObject.GetComponent<SpriteRenderer> ()
											.sprite = greybutton;
				
										Application.LoadLevel (1);
								}


						}

			
				}


			if (Input.GetKeyDown (KeyCode.Escape)) {
				Debug.Log("Escape key in start button");
				Application.Quit (); 
			}

		}
}
