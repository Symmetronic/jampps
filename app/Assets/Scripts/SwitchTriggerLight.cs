using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SwitchTriggerLight : MonoBehaviour {
public bool inTrigger;
public GameObject textbox;
public string scene;
ScoreController scoreController;


    private void Start()
    {
      scoreController = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>();
    }


    void Update(){

		if (inTrigger && !scoreController.SolvedLightMinigame1())
        {
            if (Input.GetKeyDown("space") ){		
			UnityEngine.SceneManagement.SceneManager.LoadScene(scene);	
			}
		}
		
	}
	
	void OnTriggerEnter2D (Collider2D player){
		    		
        if(!scoreController.SolvedLightMinigame1()) {
            inTrigger = true;
            textbox.SetActive(true);
        }
        // if water != 0 textbox.text = play light!


    }

    void OnTriggerExit2D (Collider2D player){
		
		inTrigger = false;
        textbox.SetActive(false);

    }

}
