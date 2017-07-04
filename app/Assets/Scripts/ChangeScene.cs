using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
    public string scene;
	// Use this for initialization
	public void Change () {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
