using UnityEngine;
using System.Collections;

public class TargetSpawnPoint : MonoBehaviour {

	public enum SpawnState{
		Creating,
		Waiting
	}


	public GameObject prefab;
	public float secondsToSpawn;
	private float secondsPassed;

	// Use this for initialization
	void Start () {
		Camera  mainCamera = FindObjectOfType<Camera> ();
	}
	
	void Update(){
		if (secondsPassed * Time.deltaTime > secondsToSpawn) {
			secondsPassed = 0f;
			Creating ();
			return;
		} else {
			secondsPassed += 0.1f;
		}
	}

	void Creating(){
		Instantiate (prefab, transform.position, Quaternion.identity);
	}


}
