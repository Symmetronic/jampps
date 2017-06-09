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
		SetActive (activated);
	}

	public void SetActive(bool active) {
		if (active) {
			SetOn ();
		} else {
			SetOff ();
		}
	}

	public void ToggleActive() {
		if (activated) {
			SetOff ();
		} else {
			SetOn ();
		}
	}

	void SetOn() {
		offState.SetActive (false);
		onState.SetActive (true);
		activated = true;
	}

	void SetOff() {
		onState.SetActive (false);
		offState.SetActive (true);
		activated = false;
        lightGameController.LightBulbChanged();
	}

}
