using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootContoller : MonoBehaviour {

	public GameObject prefab;
	public GameObject delivery;
	public float coolDownSeconds;
	public AudioClip clip;
	public AudioSource source;
	public Text text;

	private float coolDownWaited;
	private float coolDownWaitedLateral;
	private int munition;
	private Vector3 looking;

	// Use this for initialization
	void Start () {
		coolDownSeconds = 1.5f;
		looking = new Vector3 (1, 1, 0);
		source = GetComponent<AudioSource> ();
		munition = 10;
		SetCountText ();
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
		if (coolDownWaitedLateral >= coolDownSeconds && munition > 0) {
			GameObject arrow = (GameObject)Instantiate (delivery, transform.position + new Vector3(-1,1), transform.rotation);
			Rigidbody2D rbArrow = arrow.GetComponent<Rigidbody2D> ();
			rbArrow.velocity = new Vector3(-1,1) * 10f;
			coolDownWaitedLateral= 0;
			munition -=1;
			SetCountText();
			return;
		}
	}

	public void addMunition(){
		munition = 10;
		SetCountText ();
	}

	void SetCountText ()
	{
		text.text = "Count: " + munition.ToString ();

	}

}
