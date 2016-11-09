using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	private Animator anim;
	float speedfloat;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			speedfloat += 0.1f;
		} else if (speedfloat > 0) {
			speedfloat -= 0.3f;
		}
		if (Input.GetKey (KeyCode.A)) {
			gameObject.transform.Rotate(Vector3.right * Time.deltaTime);
		}
		anim.SetFloat ("speeeed", speedfloat);
	}
}
