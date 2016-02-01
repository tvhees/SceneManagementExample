using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (LoadScene ("Scene1", 2.0f));
		StartCoroutine (LoadScene ("Scene2", 4.0f));

		StartCoroutine (UnloadScene ("Scene1", 6.0f));
		StartCoroutine (UnloadScene ("Scene2", 8.0f));
	}

	IEnumerator LoadScene(string sceneName, float delay){

		yield return new WaitForSeconds (delay);

		SceneManager.LoadScene (sceneName, LoadSceneMode.Additive);
	}

	IEnumerator UnloadScene(string sceneName, float delay){
		yield return new WaitForSeconds (delay);

		if(SceneManager.GetSceneByName(sceneName)!=null)
			SceneManager.UnloadScene (sceneName);
	}
}
