using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aceleration : MonoBehaviour {
	public Text texto;
	public Transform cubo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x= Input.acceleration.x;
		float y=Input.acceleration.y;
		float z= Input.acceleration.z;

		float yy=0f;
		float xx=0f;

		texto.text="x:"+x+",y:"+y+"z:"+z;
		if(z>0.5f){yy=1.7f;}else{
		if(z<-0.5f){yy=-2.4f;}else{
			yy=0;
		}
		
		}

		if(x>0.04f){xx=-2f;}else{
			if(x<-0.04f){xx=2f;}else{
				xx=0f;

			}
		}

		cubo.position=new Vector3(xx,yy,cubo.position.z);


	}
}
