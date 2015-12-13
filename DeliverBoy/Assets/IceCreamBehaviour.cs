using UnityEngine;
using System.Collections;

public class IceCreamBehaviour : MonoBehaviour {

	private Vector3 looking;
	private Rigidbody2D rb;
	private float speed;
	
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		looking = new Vector3 (-1, -1, 0);
		speed = 1;
		
	}
	
	void FixedUpdate () {
		rb.velocity = looking * speed;
	}

	void OnCollisionEnter2D(Collision2D col){
		//if (col.collider.gameObject.tag == "PlayerBound" || col.collider.gameObject.tag == "Player") {
			Destroy (gameObject);
		//}
	}
}
