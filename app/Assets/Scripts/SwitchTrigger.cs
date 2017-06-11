using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrigger : MonoBehaviour {
public bool inTrigger;


	void Update(){
		
		if (Input.GetKeyDown("space")){
			
			if (inTrigger ){		
			UnityEngine.SceneManagement.SceneManager.LoadScene(1);	
			}
		}
		
	}
	
	void OnTriggerEnter2D (Collider2D player){
		
		inTrigger = true;
		
	}

	void OnTriggerExit2D (Collider2D player){
		
		inTrigger = false;
		
	}
	
}
