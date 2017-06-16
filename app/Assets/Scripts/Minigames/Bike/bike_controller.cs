using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bike_controller : MonoBehaviour {
	
	public GameObject player;
	public GameObject background;
	public int x = 0;
    
    int i = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
		
		if(Input.GetKey(KeyCode.LeftArrow)){
		player.transform.Translate((float)-0.02,0,0);
        
        
        }
		if(Input.GetKey(KeyCode.RightArrow)){
		player.transform.Translate((float)0.02, 0, 0);
        
        }

        if (background.transform.position.y < -70 ) {
            if (i > 80) { UnityEngine.SceneManagement.SceneManager.LoadScene(10); }
            player.transform.Translate(0,(float)0.03, 0);
            i++;
        } 
		
		if(player.transform.position.y < -15.7){
			
			
			background.transform.Translate(0,(float)0.03,0);
			
		}
	}
}
