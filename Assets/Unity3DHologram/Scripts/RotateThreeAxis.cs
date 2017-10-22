using UnityEngine;

public class RotateThreeAxis : MonoBehaviour {

	public float x = 0.0f;
	public float y = 0.0f;
	public float z = 0.0f;

	public float randomRange = 0.0f;

	void Awake()
    {
		if (randomRange > 0.0f) {
			if (x > 0.0f) x = Random.Range(x-randomRange, x+randomRange);
			if (y > 0.0f) y = Random.Range(y-randomRange, y+randomRange);
			if (z > 0.0f) z = Random.Range(z-randomRange, z+randomRange);
		}
	}

	void Update ()
    {
		transform.Rotate(Vector3.right * Time.deltaTime*x, Space.World);
		transform.Rotate(Vector3.up * Time.deltaTime*y, Space.World);
		transform.Rotate(Vector3.forward * Time.deltaTime*z, Space.World);
	}

}
