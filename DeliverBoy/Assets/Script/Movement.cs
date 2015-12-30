using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	public GameObject prefab;
	public GameObject delivery;
	public float coolDownSeconds;



	private Rigidbody2D rb;
	private Vector3 looking;
<<<<<<< HEAD
	private float coolDownWaited;
	private float coolDownWaitedLateral;
=======


>>>>>>> 8e730ea8887f24f4974184472bceb3ccca401c9f

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		speed = 2f;
		looking = new Vector3 (1, 1, 0);
<<<<<<< HEAD
		coolDownSeconds = 1.5f;
=======

>>>>>>> 8e730ea8887f24f4974184472bceb3ccca401c9f
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Current

		if (Input.anyKey) {

<<<<<<< HEAD
			if(Input.GetKey(KeyCode.X)){
				forwardShoot();
			}

			if(Input.GetKey(KeyCode.Z)){
				lateralShoot();
			}

=======
>>>>>>> 8e730ea8887f24f4974184472bceb3ccca401c9f
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
		}
		else {
			Destroy(other.gameObject);
		}
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "IceCreamBox") {
			gameObject.GetComponent<ShootContoller>().addMunition();
			return;
		}
		if (other.gameObject.tag == "Enemy") {
			Destroy (gameObject);
			GameObject.Find("Manager").GetComponent<ChangeScene>().ChangeToScene(2);
		}
	
	}

	void OnTriggerEnter(Collider other){
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
		coolDownWaited += Time.fixedDeltaTime;

	}

	void lateralShoot(){
		if (coolDownWaitedLateral >= coolDownSeconds) {
			GameObject arrow = (GameObject)Instantiate (delivery, transform.position + new Vector3(-1,1), transform.rotation);
			Rigidbody2D rbArrow = arrow.GetComponent<Rigidbody2D> ();
			rbArrow.velocity = new Vector3(-1,1) * 10f;
			coolDownWaitedLateral= 0;
			return;
		}
		coolDownWaitedLateral += Time.fixedDeltaTime;
	}
}
