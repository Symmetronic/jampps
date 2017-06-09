using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGameController : MonoBehaviour {

    public GameObject[] lightBulbs;
    public string nextScene;
	
    private bool AllLightBulbsOff()
    {
        foreach (GameObject lightBulb in lightBulbs)
        {
            ElectricityConnection electricityConnection = lightBulb.GetComponent<ElectricityConnection>();
            if (electricityConnection.activated)
                return false;
        }
        return true;
    }

    private void EndGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextScene);
    }

	public void LightBulbChanged ()
    {
        if (AllLightBulbsOff())
        {
            EndGame();
        }
    }


}
