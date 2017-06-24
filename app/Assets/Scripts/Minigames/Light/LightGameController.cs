using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGameController : MonoBehaviour {

    public GameObject[] lightBulbs;
    public string nextScene;
    public string minigameName;
    public AudioSource failureAudio;
    public GameObject errorMessage;
    public GameObject karsten;
    private int score = 0;

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
        GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>().AddScore(minigameName, score);
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextScene);
    }

	public void LightBulbChanged (bool notifyFailure)
    {
        RaiseScore();
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

    private void RaiseScore()
    {
        score++;
    }


}
