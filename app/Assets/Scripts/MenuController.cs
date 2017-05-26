using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	public void ChangeScene(string sceneName) {
		UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
	}
}
