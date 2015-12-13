using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	public GameObject prefab;
	public GameObject delivery;
	public float coolDownSeconds;


	private Rigidbody2D rb;
	private Vector3 looking;
	private float coolDownWaited;
	private float coolDownWaitedLateral;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		speed = 2f;
		looking = new Vector3 (1, 1, 0);
		coolDownSeconds = 1.5f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Current

		if (Input.anyKey) {

			if(Input.GetKey(KeyCode.X)){
				forwardShoot();
			}

			if(Input.GetKey(KeyCode.Z)){
				lateralShoot();
			}

			//Translation
			float h = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
			float v = Input.GetAxis ("Vertical") * speed * Time.deltaTime;

			Vector3 movement = new Vector3 (h,v,0.0f);
			rb.velocity = movement.normalized * speed;

		} else {
			rb.velocity = Vector3.zero;
			Debug.Log(rb.velocity);
		}
		coolDownWaited += Time.fixedDeltaTime;
		coolDownWaitedLateral += Time.fixedDeltaTime;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "PlayerBound") {
			rb.velocity = Vector3.zero;
		}
	}

	void forwardShoot(){
		if (coolDownWaited >= coolDownSeconds) {
			GameObject arrow = (GameObject)Instantiate (prefab, transform.position + looking, transform.rotation);
			Rigidbody2D rbArrow = arrow.GetComponent<Rigidbody2D> ();
			rbArrow.velocity = looking * 10f;
			coolDownWaited = 0;
			return;
		}


	}

	void lateralShoot(){
		if (coolDownWaitedLateral >= coolDownSeconds) {
			GameObject arrow = (GameObject)Instantiate (delivery, transform.position + new Vector3(-1,1), transform.rotation);
			Rigidbody2D rbArrow = arrow.GetComponent<Rigidbody2D> ();
			rbArrow.velocity = new Vector3(-1,1) * 10f;
			coolDownWaitedLateral= 0;
			return;
		}

	}
}
