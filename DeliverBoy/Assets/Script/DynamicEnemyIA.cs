using UnityEngine;
using System.Collections;

public class DynamicEnemyIA : MonoBehaviour {

<<<<<<< HEAD
=======
	public float division = 40;

>>>>>>> 8e730ea8887f24f4974184472bceb3ccca401c9f
	private Vector3 looking;
	private Rigidbody2D rb;
	private float speed;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		looking = new Vector3 (-1, -1, 0);
<<<<<<< HEAD
		//speed = Random.value * Time.time / 120f;
		speed = 1;
=======
		speed = Random.value * Time.time/division +1 ;
		//speed = 1;

>>>>>>> 8e730ea8887f24f4974184472bceb3ccca401c9f
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = looking * speed;
	}

	void OnTriggerEnter2D(Collider2D other){
<<<<<<< HEAD
		Destroy (gameObject);
=======
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
>>>>>>> 8e730ea8887f24f4974184472bceb3ccca401c9f
	}

	void OnBecameInvisible(){
		Debug.Log ("I became invisible");
		Destroy(gameObject);
	}



}
