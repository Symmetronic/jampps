using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTriggerWater : MonoBehaviour {
public bool inTrigger;
    public GameObject textbox;
    public string scene;
    ScoreController scorecontroller;

    private void Start()
    {
        scorecontroller = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>();
    }

    void Update(){
		
		if (inTrigger)
        {
            if (Input.GetKeyDown("space") && !scorecontroller.SolvedWaterMinigame1()){		
			UnityEngine.SceneManagement.SceneManager.LoadScene(scene);	
			}
		}
		
	}
	
	void OnTriggerEnter2D (Collider2D player){

        if (!scorecontroller.SolvedWaterMinigame1())
        {
            inTrigger = true;
            textbox.SetActive(true);

        }

    }

    void OnTriggerExit2D (Collider2D player){
		
		inTrigger = false;
        textbox.SetActive(false);

    }

}
