using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {
	
	void Update () 
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		transform.position = new Vector3( transform.position.x, ray.GetPoint(1000f).y, 0f);
	}
}