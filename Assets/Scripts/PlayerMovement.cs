using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public KeyCode keyLeft;
	public KeyCode keyRight;

	public KeyCode keyUp;
	public KeyCode keyDown;

	public float speed = 1;

	float direction;
	Rigidbody2D rb;

	Transform pick;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		pick = transform.GetChild(0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (keyRight)) {
			direction = -1;
		}

		if (Input.GetKey (keyLeft)) {
			direction = 1;
		}

		if (!Input.GetKey (keyLeft) && !Input.GetKey (keyRight)) {
			direction = 0;
		}

		if (Input.GetKey (keyUp)) {
			MovePick (.3f);
		} else {
			MovePick (.156f);
		}

		if (Input.GetKey (keyDown)) {
			MovePick (.04f);
		}else{
			MovePick (.156f);
		}

		rb.angularVelocity = direction * speed;
	}

	void MovePick(float target)
	{
		Vector3 targetPosition = new Vector3 (target, pick.localPosition.y, pick.localPosition.z);
		Vector3 newPos = Vector3.Lerp (pick.localPosition, targetPosition, .1f);
		pick.localPosition = newPos;
	}
}
