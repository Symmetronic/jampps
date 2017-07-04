using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTriggerWithoutSceneSwitch : MonoBehaviour {
public bool inTrigger;
   public GameObject textbox;
    

	void Update(){

        
		
		
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
