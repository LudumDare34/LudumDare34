using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnScenario : MonoBehaviour {

	public enum GenerationTarget{
		Ground,
		Road,
		Houses
	}

	public GenerationTarget target;
	public float secondsToSpawn;
	public float secondsOffset;
	public GameObject prefab;
	private float secondsPassed = 0f;


	// Use this for initialization
	void Start () {
		Creating ();
	}
	
	// Update is called once per frame
	void Update () {
		if (secondsPassed * Time.deltaTime  > secondsToSpawn) {
			secondsPassed = 0f;
			Creating ();
			return;
		} else {
			secondsPassed += 0.1f;
		}
	}

	void Creating(){
		Instantiate (prefab, transform.position , prefab.transform.rotation);
	}
	
}
