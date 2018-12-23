using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}

}
