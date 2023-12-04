using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public void ChangeScene(string sceneName) {
        Debug.Log("Changing scene to " + sceneName);
		SceneManager.LoadScene (sceneName);
	}

	public void Exit() {
        Debug.Log ("Exiting game");
		Application.Quit ();
	}
}