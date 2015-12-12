using UnityEngine;
using System.Collections;

public class DynamicEnemyIA : MonoBehaviour {

	private Vector3 looking;
	private Rigidbody2D rb;
	private float speed;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		looking = new Vector3 (-1, -1, 0);
		//speed = Random.value * Time.time / 120f;
		speed = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = looking * speed;
	}

	void OnTriggerEnter(Collider other){
		Destroy (gameObject);
	}

}
