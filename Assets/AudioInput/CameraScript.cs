using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform Target;
	public bool LockX, LockY, LockZ = true;

	Vector3 _startPos;

	// Use this for initialization
	void Start () {
		_startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Target.position;

		if(LockX) pos.x = _startPos.x;
		if(LockY) pos.y = _startPos.y;
		if(LockZ) pos.z = _startPos.z;

		transform.position = pos;
	}
}
