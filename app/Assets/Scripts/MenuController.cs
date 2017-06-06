using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	public void ChangeScene(string scene) {
		UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
	}
}
