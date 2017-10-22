using UnityEngine;
using System.Collections;

public class Plant : MonoBehaviour {
	public float earthspeed;
	void Update () {
		float x = transform.position.x;
		if (Input.GetKeyDown ("l")) {
			if (x != 0) {
				transform.position = new Vector3 (0f, -0.06f, 0f);
			}
		}
		transform.Rotate (0f, Time.deltaTime*earthspeed, 0f);
	}
}
