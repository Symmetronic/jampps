using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bike_map_movement : MonoBehaviour {
	public GameObject background;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		background.transform.Translate (0, (float)-0.05, 0);
	}
}
