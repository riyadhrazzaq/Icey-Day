using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class DeadByContact : MonoBehaviour {
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
		if (other.tag == "Player")
		{
			//Destroy (other.gameObject);
			Debug.Log ("mara gese");
			SceneManager.LoadScene ("Home");
		}
		//gameController.AddScore (scoreValue);
	}





}
