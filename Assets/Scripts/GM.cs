using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour {
	
	public int player1score = 0;
	public int player2score = 0;
	public float resetDelay = 1f;
	public Text player1Text;
	public Text player2Text;
	public GameObject ball;
	public static GM instance = null;

	private GameObject cloneBall;
	
	// Use this for initialization
	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}
	
	public void givePoint1()
	{
		player1score++;
		player1Text.text = "Player 1: " + player1score;
	}

	public void givePoint2()
	{
		player2score++;
		player2Text.text = "Player 2: " + player2score;
	}

}