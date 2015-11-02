using UnityEngine;
using System.Collections;

public class GloryObject : MonoBehaviour {

	Light _pointLight;

	// Use this for initialization
	void Start () {
		_pointLight = gameObject.GetComponentInChildren<Light>();

	}
	
	// Update is called once per frame
	void Update () {

		_pointLight.intensity = 4.16f + Mathf.Sin(Time.timeSinceLevelLoad) * 0.5f;
		transform.position = new Vector3( 1.26f, 2.66f + Mathf.Sin(Time.timeSinceLevelLoad * 2f) * 0.3f, -0.66f);
	}
}
