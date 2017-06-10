using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

	public void ToggleSound() {
        if (AudioListener.volume == 0.0f)
            AudioListener.volume = 1.0f;
        else
            AudioListener.volume = 0.0f;
	}
}
