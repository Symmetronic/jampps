using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricityConnection : MonoBehaviour {

	public GameObject onState;
	public GameObject offState;
	public bool activated;
    private LightGameController lightGameController;

	void Start() {
        lightGameController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LightGameController>();
		SetActive (activated, true);
	}

	public void SetActive(bool active, bool init=false) {
		if (active) {
			SetOn (false, init);
		} else {
			SetOff (init);
		}
	}

	public void ToggleActive() {
		if (activated) {
			SetOff ();
		} else {
			SetOn ();
		}
	}

	void SetOn(bool playSound=true, bool init=false) {
		offState.SetActive (false);
		onState.SetActive (true);
		activated = true;
		if (!init)
        	lightGameController.LightBulbChanged(playSound);
	}

	void SetOff(bool init=false) {
		onState.SetActive (false);
		offState.SetActive (true);
		activated = false;
		if (!init)
        	lightGameController.LightBulbChanged(false);
	}

}
