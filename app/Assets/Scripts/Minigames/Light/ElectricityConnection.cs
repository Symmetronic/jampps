using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricityConnection : MonoBehaviour {

	public GameObject OnState;
	public GameObject OffState;
	public bool Activated;

	void Start() {
		SetActive (Activated);
	}

	public void SetActive(bool active) {
		if (active) {
			SetOn ();
		} else {
			SetOff ();
		}
	}

	public void ToggleActive() {
		if (Activated) {
			SetOff ();
		} else {
			SetOn ();
		}
	}

	void SetOn() {
		OffState.SetActive (false);
		OnState.SetActive (true);
		Activated = true;
	}

	void SetOff() {
		OnState.SetActive (false);
		OffState.SetActive (true);
		Activated = false;
	}

}
