using UnityEngine;
using System.Collections;

public class ShootContoller : MonoBehaviour {

	public GameObject prefab;
	public GameObject delivery;
	public float coolDownSeconds;
	public AudioClip clip;
	public AudioSource source;

	private float coolDownWaited;
	private float coolDownWaitedLateral;
	private int munition;
	private Vector3 looking;

	// Use this for initialization
	void Start () {
		coolDownSeconds = 1.5f;
		looking = new Vector3 (1, 1, 0);
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		coolDownWaited += Time.fixedDeltaTime;
		coolDownWaitedLateral += Time.fixedDeltaTime;

		if(Input.GetKey(KeyCode.X)){
			forwardShoot();
		}
		
		if(Input.GetKey(KeyCode.Z)){
			lateralShoot();
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "IceCreamBox") {
			munition += 2;
			if(munition > 10){
				munition = 10;
			}
		}
	}

	void forwardShoot(){
		if (coolDownWaited >= coolDownSeconds) {
			GameObject arrow = (GameObject)Instantiate (prefab, transform.position + looking, transform.rotation);
			Rigidbody2D rbArrow = arrow.GetComponent<Rigidbody2D> ();
			rbArrow.velocity = looking * 10f;
			coolDownWaited = 0;

			source.Play();
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
