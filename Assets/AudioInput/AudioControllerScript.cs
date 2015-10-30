using UnityEngine;
using System.Collections;

public class AudioControllerScript : MonoBehaviour {

	public float 
		Speed = 20f,
		JumpPower = 300f,
		MicCutoff = 0.5f
		;

	Rigidbody _rigidbody;
	float _lastLevel = 0f;
	bool _isGrounded = false;

	// Use this for initialization
	void Start () {
		_rigidbody = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		if( _isGrounded && MicInput.MicLoudness > 0.4f ) {
			Debug.Log ("jumping");
			_rigidbody.AddForce(Vector3.up * JumpPower);
			return;
		}

		float curLevel = Mathf.Min (MicCutoff, MicInput.MicLoudness); 


		if(_isGrounded && curLevel > 0.03f) {
			Vector3 vel = _rigidbody.velocity;
			vel.x += 0.5f;
			vel.x = Mathf.Min (vel.x, 6f);
			_rigidbody.velocity = vel;
		} 
		else if (_isGrounded) {
			Vector3 vel = _rigidbody.velocity;
			vel.x *= 0.9f;
			_rigidbody.velocity = vel;
		}

		_lastLevel = curLevel;
		Debug.Log (_isGrounded);
	}

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag == "Ground")
			_isGrounded = true;
	}

	void OnCollisionExit(Collision other) {
		if(other.gameObject.tag == "Ground")
			_isGrounded = false;
	}
}
