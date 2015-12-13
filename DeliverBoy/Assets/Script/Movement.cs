using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;


	private Rigidbody2D rb;
	private Vector3 looking;



	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		speed = 2f;
		looking = new Vector3 (1, 1, 0);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Current

		if (Input.anyKey) {

			//Translation
			float h = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
			float v = Input.GetAxis ("Vertical") * speed * Time.deltaTime;

			Vector3 movement = new Vector3 (h,v,0.0f);
			rb.velocity = movement.normalized * speed;

		} else {
			rb.velocity = Vector3.zero;
			Debug.Log(rb.velocity);
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "PlayerBound") {
			rb.velocity = Vector3.zero;
		} else {
			Destroy(other.gameObject);
		}

	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Enemy") {

			///////////////////////Aquí game over!!!!!!
			Destroy (gameObject);
		}
	
	}


}
