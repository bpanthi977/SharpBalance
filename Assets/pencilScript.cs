using UnityEngine;
using System.Collections;

public class pencilScript : MonoBehaviour {

	public float forceFactor = 0.1f;

	GameObject pencil;
	Rigidbody rb;
	Vector3	i0 = new Vector3(0, 1 ,1);
	Vector3 j0 = new Vector3(1,0,1);

	void Start () {
		pencil = this.gameObject;
		rb = pencil.GetComponent<Rigidbody> ();
	}
	
	void FixedUpdate () {
		float hor = Input.GetAxis ("Horizontal");
		float ver = Input.GetAxis ("Vertical");
		// Cancle opposite velocity
		if (hor * rb.velocity.x < 0) {  // if hor and veclocity are opposite
			rb.velocity.Set (0, rb.velocity.y, rb.velocity.z);
		
		}
		if (ver * rb.velocity.y < 0)
			rb.velocity.Set (rb.velocity.x, 0, rb.velocity.z);
			
		// Apply force
		rb.AddForce (forceFactor* hor , forceFactor* ver , 0,ForceMode.Impulse);

		

	}
}
