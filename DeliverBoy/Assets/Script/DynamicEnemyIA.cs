using UnityEngine;
using System.Collections;

public class DynamicEnemyIA : MonoBehaviour {

	public float division = 40;

	private Vector3 looking;
	private Rigidbody2D rb;
	private float speed;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		looking = new Vector3 (-1, -1, 0);
		speed = Random.value * Time.time/division;
		//speed = 1;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = looking * speed;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "IceCream") {
			Destroy (other.gameObject);
		} else {
			Destroy(other.gameObject);
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.collider.gameObject.tag == "PlayerBound") {
			Destroy (gameObject);
		}
	}

	void OnBecameInvisible(){
		Debug.Log ("I became invisible");
		Destroy(gameObject);
	}



}
