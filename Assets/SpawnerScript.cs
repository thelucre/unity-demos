using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public Transform Prefab;
	public int SpawnPerSecond = 2;
	public float Delay = 1f;
	public float StopAt = 5f;

	float _timeSpawning = 0f;

	// Use this for initialization
	void Start () {
		Invoke ("Spawn", Delay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn() {
		_timeSpawning += (1f / SpawnPerSecond);
		Instantiate(Prefab, transform.position,Quaternion.identity);

		if(_timeSpawning < StopAt)
			Invoke ("Spawn", 1f / SpawnPerSecond);
	}
}
