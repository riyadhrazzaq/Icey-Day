using UnityEngine;
using System.Collections;

public class DestroyByDeyal : MonoBehaviour
{
	private int scoreValue=10;
	private GameController gameController;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") {
			gameController.AddScore (scoreValue);
			Debug.Log ("Passed");
		}

	}
}