using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	
	public float ballInitialVelocity = 900f;

	private Rigidbody rb;
	public bool ballInPlay;
	public int dir;
	
	public void player1 () {
		dir = 1;
	}

	public void player2 () {
		dir = -1;
	}

	public void Play() {
		ballInPlay = true;
	}

	void Awake () {
		
		rb = GetComponent<Rigidbody>();
		rb.maxAngularVelocity = 999999f;
		
	}

	void OnTriggerEnter ()
	{
		Reset ();
	}

	void OnCollision ()
	{
		rb.velocity = Vector3.Scale(rb.velocity, new Vector3(1.5f,1.5f,0));
	}

	void Reset ()
	{
		transform.position = new Vector3 (0, 0, 0);
		transform.rotation = Quaternion.identity;
		rb.isKinematic = true;
		rb.velocity.Set (0, 0, 0);
	}
	
	void Update () 
	{
		if (Input.GetButtonDown("Fire1") && ballInPlay)
		{
			transform.parent = null;
			rb.isKinematic = false;
			if (rb.velocity.x >= 0) {
				dir = 1;
			} else {
				dir = -1;
			}
			Vector3 randForce = Vector3.Scale(new Vector3(Random.Range (4000f, 6000f), Random.Range (-1000f, 1000f), 0), new Vector3(dir,1f,0));
			rb.AddForce(randForce);
		}
//		Vector3 normVel = rb.velocity.normalized;
//		Vector3 newVel = Vector3.Scale (normVel, new Vector3(600f,600f,600f));
//		rb.velocity = newVel;
	}
}