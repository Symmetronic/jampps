using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGameController : MonoBehaviour {

    public GameObject[] lightBulbs;
    public string nextScene;
    public AudioSource failureAudio;
    public GameObject errorMessage;
    public GameObject karsten;

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

	public void LightBulbChanged (bool notifyFailure)
    {
        if (notifyFailure)
        {
            failureAudio.Play();
            ShowErrorMessage();
        } else if (AllLightBulbsOff()) {
            EndGame();
        }
    }

    private void ShowErrorMessage()
    {
        VisibilityController visibilityController = errorMessage.GetComponent<VisibilityController>();
        visibilityController.Show(errorMessage);
        visibilityController.Show(karsten);
    }


}
