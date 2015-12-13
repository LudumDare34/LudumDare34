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
		spriteRenderer.sprite = happySprite;
		source.Play ();
	}

}
