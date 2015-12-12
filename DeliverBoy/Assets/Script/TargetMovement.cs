﻿using UnityEngine;
using System.Collections;

public class TargetMovement : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb;

	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 movement = new Vector3 (-1,-1,0.0f);
		rb.velocity = movement.normalized * speed;

	}

	void OnBecameInvisible(){
		Destroy(gameObject);
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("I have My Icecream");
		Destroy (other.gameObject);
	}

}
