using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bike_car : MonoBehaviour {
	public GameObject background;
    public float speed;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		background.transform.Translate (0, (float)speed, 0);
	}
}
