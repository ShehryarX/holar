using UnityEngine;
using System.Collections;

public class Pencil : MonoBehaviour {

	public float earthspeed;
	// Update is called once per frame
	void Update () {
		float x = transform.position.x;
		if (Input.GetKeyDown ("p")) {
			if (x != 0) {
				transform.position = new Vector3 (0.09f, 0.24f, 0.63f);
			}
		}
		transform.Rotate (0.09f, Time.deltaTime*earthspeed, 0.63f);
	}
}
