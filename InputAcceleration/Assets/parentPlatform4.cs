using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentPlatform4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="p4")
		{transform.SetParent(other.transform);}
	}
}
