using System.Collections;
using UnityEngine;

public class ControllerCodymod: MonoBehaviour{

	public float jumpVelocity;
	public float speed;
	float jumpAmt;
	float moveHorizontal;
	float moveVertical;

	private Rigidbody rg;



	void Start(){
		rg = GetComponent<Rigidbody> ();		
	}
	void Update(){
		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");
		jumpAmt = Jump();

	}
	void FixedUpdate(){
		Vector3 movement = new Vector3 (moveHorizontal, jumpAmt, moveVertical);
		rg.AddForce (movement*speed);

	}

	public float Jump (){
		float Jump = 2.0f;
		if (Input.GetButtonDown ("Jump")) {
			rg.velocity = Vector3.up * jumpVelocity;
		}
		return Jump;
	}
}
