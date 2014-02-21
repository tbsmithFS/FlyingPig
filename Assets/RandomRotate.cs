using UnityEngine;
using System.Collections;

public class RandomRotate : MonoBehaviour {

	float rotateSpeed;

	// Use this for initialization
	void Start () {
		rotateSpeed = Random.Range(-380, 380);
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
	}
}
