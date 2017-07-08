using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrigger_ChangeScene_withspace_home : MonoBehaviour
{
    public bool inTrigger;
    public GameObject textbox;
    public string scene;
    ScoreController scoreController;

	void Start()
	{
		scoreController = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>();
	}

    void Update()
    {
        if (inTrigger)
        {
            if (scoreController.SolvedWaterMinigame2() && Input.GetKeyDown("space"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D player)
    {
        if (scoreController.SolvedWaterMinigame2())
        {
            inTrigger = true;
            textbox.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D player)
    {

        inTrigger = false;
        textbox.SetActive(false);

    }

}
