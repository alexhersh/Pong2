using UnityEngine;
using System.Collections;

public class p1Zone : MonoBehaviour {
	
	void OnTriggerEnter (Collider col)
	{
		GM.instance.givePoint2();
	}
}