using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {
	Rigidbody _rigidbody;
	// Use this for initialization
	void Start () {
		_rigidbody = gameObject.GetComponent<Rigidbody>();
		_rigidbody.AddForceAtPosition(Vector3.up * Random.Range( 400f,900f), Random.insideUnitSphere * 2);
	}
	
	// Update is called once per frame
	void Update () {
//		transform.Rotate(0,5,0);
	}
}
