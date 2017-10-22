using UnityEngine;
using System.Collections;

public class KeyL : MonoBehaviour {

	public float earthspeed;
	// Update is called once per frame
	void Update () {
		float x = transform.position.x;
		if (Input.GetKeyDown ("e")) {
			if (x != 0) {
				transform.position = new Vector3 (0f, 0f, 0.6365f);
			}
		}
		transform.Rotate (0f, Time.deltaTime*earthspeed, 0.6365f);
	}
}
