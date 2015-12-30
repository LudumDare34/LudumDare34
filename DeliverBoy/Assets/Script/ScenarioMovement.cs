using UnityEngine;
using System.Collections;

public class ScenarioMovement : MonoBehaviour {

	private Vector3 movement;
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		movement = new Vector3 (-1, -1, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = movement;
	}

	void OnBecameInvisible(){
		Debug.Log ("I became invisible");
		Destroy(gameObject);
	}
}
