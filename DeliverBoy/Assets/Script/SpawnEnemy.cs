using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
	public GameObject prefab;
	public float secondsToSpawn;
	private float secondsPassed;
	
	// Use this for initialization
	void Start () {
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
		Instantiate (prefab, transform.position + new Vector3(Random.value*3,0,0), Quaternion.identity);
	}
	

}
