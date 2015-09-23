using UnityEngine;
using System.Collections;

public class p2Zone : MonoBehaviour {
	
	void OnTriggerEnter (Collider col)
	{
		GM.instance.givePoint1();
	}
}