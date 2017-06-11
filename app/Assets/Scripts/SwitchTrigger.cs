using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrigger : MonoBehaviour {
public bool inTrigger;
   public GameObject textbox;

	void Update(){
		
		if (inTrigger)
        {
            if (Input.GetKeyDown("space")){		
			UnityEngine.SceneManagement.SceneManager.LoadScene(1);	
			}
		}
		
	}
	
	void OnTriggerEnter2D (Collider2D player){
		
		inTrigger = true;
        textbox.SetActive(true);


    }

    void OnTriggerExit2D (Collider2D player){
		
		inTrigger = false;
        textbox.SetActive(false);

    }

}
