using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
	}

	public void ToggleSound() {
		if (audio.mute)
			audio.mute = false;
		else
			audio.mute = true;
	}
}
