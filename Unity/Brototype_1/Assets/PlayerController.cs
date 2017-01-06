using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	//Movement variables
	public float maxSpeedX;
	public float maxSpeedY;
	Rigidbody2D myRb;
	Animator animator;
	bool facingRight;


	// Use this for initialization
	void Start () {
		myRb = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
		facingRight = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");
		myRb.velocity = new Vector2 (moveX * maxSpeedX,moveY * maxSpeedY);

		if (moveX > 0 && !facingRight) {
			flip ();
		} else if (moveX < 0 && facingRight) {
			flip ();
		}
	}

	void flip (){
		facingRight = !facingRight;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}
		
}
