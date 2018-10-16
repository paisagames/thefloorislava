using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotacionn : MonoBehaviour {
public float x;
public float y;
public float z;
public Text texto;
public Transform esfera;

float xes;
float yes;

	// Use this for initialization
	void Start () {
		xes=0f;
		yes=0f;
	}
	
	// Update is called once per frame
	void Update () {
		x=Input.acceleration.x/10f;
		y=Input.acceleration.y/10f;
		z=Input.acceleration.z;
		texto.text="x:"+x+", y:"+y+ ", z:"+z;
		//transform.Rotate(-z,0,0);
		//transform.Rotate(0,-x*80f,0);
		transform.Rotate(-z,-x*180f,0);

		float x2=0f;float z2=0f;
		if(x>0.01f){x2=-0.5f; xes=-3f;
		}else{if(x<-0.01f){x2=0.5f;xes=3f;}else{x2=0;xes=0;}}

		if(z>0.001f){z2=-0.5f;
		yes=-3f;}else{if(z<-0.001f){z2=0.5f;yes=3f;}else{z2=0;yes=0f;}}

		//transform.Rotate(z2,x2,0);	
		esfera.transform.localPosition=new Vector3(xes,yes,7.14f);

		//cuando el telefono esta acostado la aceleracion en y es cero
	
	}
}
