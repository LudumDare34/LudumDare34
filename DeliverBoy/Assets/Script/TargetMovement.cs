using UnityEngine;
using System.Collections;

public class TargetMovement : MonoBehaviour {

	public float speed;
	public Sprite happySprite;
	private Rigidbody2D rb;
	private SpriteRenderer spriteRenderer;
	private AudioSource source;

	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		source = gameObject.GetComponent<AudioSource> ();
		speed = Random.value * Time.time/40 +1 ;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 movement = new Vector3 (-1,-1,0.0f);
		rb.velocity = movement.normalized * speed;

	}

	void OnBecameInvisible(){
		Destroy(gameObject);
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("I have My Icecream");
		Destroy (other.gameObject);
<<<<<<< HEAD
=======
		spriteRenderer.sprite = happySprite;
		source.Play ();
>>>>>>> 8e730ea8887f24f4974184472bceb3ccca401c9f
	}

}
