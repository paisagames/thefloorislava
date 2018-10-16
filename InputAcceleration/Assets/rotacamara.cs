using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacamara : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){
			transform.Rotate(0,-0.2f,0);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Rotate(0,0.2f,0);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Rotate(0.2f,0,0);
		}
		if(Input.GetKey(KeyCode.W)){
			transform.Rotate(-0.2f,0,0);
		}
		
	}
}
