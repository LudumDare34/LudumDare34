using UnityEngine;
using System.Collections;

public class SpawnIceCReamBoxes : MonoBehaviour {
	public GameObject IceCreamBoxPrefab;
	public float secondsToSpawn;
	private float secondsWaited;

	// Use this for initialization
	void Start () {
		secondsToSpawn = 10;
		secondsWaited = 0;
	}
	
	// Update is called once per frame
	void Update () {
		secondsWaited += Time.deltaTime;
		if (secondsWaited >= secondsToSpawn) {
			spawn();
		}
	}

	void spawn(){
		Instantiate (IceCreamBoxPrefab, transform.position + new Vector3(Random.value*6,0,0), Quaternion.identity);
	}
}
