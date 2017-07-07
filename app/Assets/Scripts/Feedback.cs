using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedback : MonoBehaviour {
	public GameObject light1Gold;
	public GameObject light1Silver;
	public GameObject light2Gold;
	public GameObject light2Silver;
	public GameObject snakeGold;
	public GameObject snakeSilver;
	public GameObject water1Gold;
	public GameObject water1Silver;
	public GameObject water2Gold;
	public GameObject water2Silver;

	private ScoreController scoreCtrl;

	void Start () {
		scoreCtrl = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>();

		ShowBadge("light1", scoreCtrl.GetBadge("light1"));
		ShowBadge("light2", scoreCtrl.GetBadge("light2"));
		ShowBadge("snake", scoreCtrl.GetBadge("snake"));
		ShowBadge("water1", scoreCtrl.GetBadge("water1"));
		ShowBadge("water2", scoreCtrl.GetBadge("water2"));
	}

	private void ShowBadge(string minigame, string badge) {
		switch(minigame)
		{
			case "light1":
				if (badge == "gold")
					Show(light1Gold);
				else
					Show(light1Silver);
				break;
			case "light2":
				if (badge == "gold")
					Show(light2Gold);
				else
					Show(light2Silver);
				break;
			case "snake":
				if (badge == "gold")
					Show(snakeGold);
				else
					Show(snakeSilver);
				break;
			case "water1":
				if (badge == "gold")
					Show(water1Gold);
				else
					Show(water1Silver);
				break;
			case "water2":
				if (badge == "gold")
					Show(water2Gold);
				else
					Show(water2Silver);
				break;
		}
	}

	public void Show(GameObject obj) {
		obj.SetActive(true);
	}
}
