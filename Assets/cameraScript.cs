using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {
	public GameObject lookAt; // Sharpner where the camera has to look i.e rotatate 
	GameObject camera;
	// Use this for initialization
	void Start () {
		camera = gameObject;
	}

	float calculateAngle (Vector3 rotation , Vector3 axis) {

		Vector3 dcs = new Vector3 (Mathf.Cos (rotation.x * Mathf.PI / 180f),
			              Mathf.Cos (rotation.x * Mathf.PI / 180f),
			              Mathf.Cos (rotation.x * Mathf.PI / 180f));
		return Vector3.Angle (dcs,axis	);
	}

	// Update is called once per frame
	void Update () {
		if (lookAt) {
			//Vector3 axis = camera.transform.position - lookAt.transform.position;
			//Vector3 rotation = camera.transform.eulerAngles;
			//Debug.Log (angle);
			//camera.transform.RotateAround (lookAt.transform.position, axis, calculateAngle (rotation, axis));
			camera.transform.LookAt(lookAt.transform.position);
		}
	}
}
