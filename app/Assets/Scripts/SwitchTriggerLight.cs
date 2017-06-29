using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTriggerLight : MonoBehaviour {
public bool inTrigger;
   public GameObject textbox;
   public string scene;

	void Update(){
		
		if (inTrigger)
        {
            if (Input.GetKeyDown("space") ){		
			UnityEngine.SceneManagement.SceneManager.LoadScene(scene);	
			}
		}
		
	}
	
	void OnTriggerEnter2D (Collider2D player){
		
		inTrigger = true;
        textbox.SetActive(true);

        // if water != 0 textbox.text = play light!


    }

    void OnTriggerExit2D (Collider2D player){
		
		inTrigger = false;
        textbox.SetActive(false);

    }

}
