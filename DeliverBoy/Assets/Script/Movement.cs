using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		speed = 2f;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Current
		Debug.DrawRay (transform.position, transform.forward);
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


}
