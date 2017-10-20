using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

public Rigidbody rb;
public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update(){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);

		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);
	}

}
