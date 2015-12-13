using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis ("Horizontal") > 0) {
			Debug.Log("Derecha");
			animator.SetFloat("horizontal",1f);
			animator.SetFloat("vertical",0f);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			animator.SetFloat("horizontal",-1f);
			animator.SetFloat("vertical",0f);
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			animator.SetFloat("vertical",1f);
			animator.SetFloat("horizontal",0f);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			animator.SetFloat("horizontal",0f);
			animator.SetFloat("vertical",-1f);
		}
	}
}
