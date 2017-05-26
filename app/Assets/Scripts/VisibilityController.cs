using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityController : MonoBehaviour {

	public void Hide(GameObject obj) {
		obj.SetActive(false);
	}

	public void Show(GameObject obj) {
		obj.SetActive(true);
	}

}
