using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class disparo : MonoBehaviour {
	public static string colisionobool;
	public Text texto;
	public Transform garra;
	public Rigidbody projectil;
	string action;
	public Transform puntodelanzamiento;
	bool[] boollist=new bool[50];
	// Use this for initialization
	void Start () {
		for(int i=0;i<=boollist.Length-1;i++){
			
			boollist[i]=false;

		}
		action="";
		colisionobool="inicia";
	}
	
	// Update is called once per frame
	void Update () {
		float LX=Input.GetAxisRaw("Oculus_GearVR_LIndexTrigger");
		float LY=Input.GetAxisRaw("Oculus_GearVR_LThumbstickY");
		float RX=Input.GetAxisRaw("Oculus_GearVR_RThumbstickX");
		float RY=Input.GetAxisRaw("Oculus_GearVR_RThumbstickY");
		float DX=Input.GetAxisRaw("Oculus_GearVR_DpadX");
		float DY=Input.GetAxisRaw("Oculus_GearVR_DpadY");
		float LYT=Input.GetAxisRaw("Oculus_GearVR_LIndexTrigger");
		float RYT=Input.GetAxisRaw("Oculus_GearVR_RIndexTrigger");


		//texto.text="LX:"+LX+"/LY:"+LY+"/RX:"+RX+"/RY:"+RY+"/DX:"+DX+"/DY:"+DY+"/LYT:"+LYT+"/RYT:"+RYT;
		boollist[0]=OVRInput.GetControllerWasRecentered();
		boollist[1]=OVRInput.Get(OVRInput.Button.One);
		boollist[2]=OVRInput.GetDown(OVRInput.Button.One);
		boollist[3]=OVRInput.GetUp(OVRInput.Button.One);
		boollist[4]=OVRInput.Get(OVRInput.Touch.One);//dejas tocas el de arriba
		boollist[5]=OVRInput.GetDown(OVRInput.Touch.One);//tocas una vez
		boollist[6]=OVRInput.GetUp(OVRInput.Touch.One);//sueltas
		boollist[7]=OVRInput.Get(OVRInput.Button.Two);
		boollist[8]=OVRInput.GetDown(OVRInput.Button.Two);
		boollist[9]=OVRInput.GetUp(OVRInput.Button.Two);//back
		boollist[10]=OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger);//disparo dejas oprimido
		boollist[11]=OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger);//disparo oprimes una vez
		boollist[12]=OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger);//disparo sueltas
		boollist[13]=OVRInput.Get(OVRInput.Touch.PrimaryIndexTrigger);
		boollist[14]=OVRInput.GetDown(OVRInput.Touch.PrimaryIndexTrigger);
		boollist[15]=OVRInput.GetUp(OVRInput.Touch.PrimaryIndexTrigger);
		boollist[16]=OVRInput.Get(OVRInput.Button.PrimaryHandTrigger);
		boollist[17]=OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger);
		boollist[18]=OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger);
		boollist[19]=OVRInput.Get(OVRInput.Button.Up);
		boollist[20]=OVRInput.Get(OVRInput.Button.Down);
		boollist[21]=OVRInput.Get(OVRInput.Button.Left);
		boollist[22]=OVRInput.Get(OVRInput.Button.Right);
		boollist[23]=OVRInput.Get(OVRInput.Button.PrimaryTouchpad);
		boollist[24]=OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad);
		boollist[25]=OVRInput.GetUp(OVRInput.Button.PrimaryTouchpad);
		boollist[26]=OVRInput.Get(OVRInput.Touch.PrimaryTouchpad);//tocas el de arriba
		boollist[27]=OVRInput.GetDown(OVRInput.Touch.PrimaryTouchpad);//dejas tocado eld e arriba
		boollist[28]=OVRInput.GetUp(OVRInput.Touch.PrimaryTouchpad);//sueltas el de arriba
		boollist[29]=OVRInput.Get(OVRInput.RawButton.Start);
		boollist[30]=OVRInput.GetDown(OVRInput.RawButton.Start);
		boollist[31]=OVRInput.GetUp(OVRInput.RawButton.Start);
		boollist[32]=OVRInput.Get(OVRInput.RawButton.Back);
		boollist[33]=OVRInput.GetDown(OVRInput.RawButton.Back);
		boollist[34]=OVRInput.GetUp(OVRInput.RawButton.Back);//back
		boollist[35]=OVRInput.Get(OVRInput.RawButton.A);//disparo oprimes
		boollist[36]=OVRInput.GetDown(OVRInput.RawButton.A);
		boollist[37]=OVRInput.GetUp(OVRInput.RawButton.A);
		boollist[38]=OVRInput.Get(OVRInput.RawTouch.RThumbstick);
	
		texto.text="NU";

		for(int i=0;i<=boollist.Length-1;i++){
			if(boollist[i]==true){
				texto.text+="b"+i+",";
			}

		}

		//texto.text="x="+x;
		if(boollist[10]==true||Input.GetKeyDown(KeyCode.Space)){
		
		disparagarra();}
		
	
	if(colisionobool=="atrapado"){
		if(garra.localPosition.z>0.394){garra.transform.Translate(0,0,-0.01f);}else{
			colisionobool="inicia";
		}


		//garra.localPosition=new Vector3(0,-0.125f,0.394f);
	}else{
		if(colisionobool=="lanza"){
		garra.Translate(0,0,0.02f);
	//	collide_garra.agarra=true;
		}
			
			
		
	}

	}
		void dispara(){


				Rigidbody instantiatedProjectile = Instantiate (projectil, puntodelanzamiento.position, projectil.rotation) as Rigidbody;

			instantiatedProjectile.velocity=puntodelanzamiento.transform.TransformDirection(new Vector3(0,0,5f));
			
		
		
		


		}
		public void disparagarra(){
			colisionobool="lanza";

		}
		
		
		
	}

