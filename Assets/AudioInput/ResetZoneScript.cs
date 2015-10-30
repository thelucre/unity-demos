using UnityEngine;
using System.Collections;

public class ResetZoneScript : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {
			Application.LoadLevel(Application.loadedLevelName);
		}
	}
}
