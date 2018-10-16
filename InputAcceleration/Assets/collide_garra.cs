using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collide_garra : MonoBehaviour {
	//public Transform esferitadelfrente;
	//public float masanostaticMONO;
	public Transform ojos;
	public Transform plataforma;
	public Text text;
	public Transform center_eye_Ancher;
	public Animator animacion;
	//string colisionobool;
	
	bool[] boollist=new bool[50];
	string movimiento_actual_de_cadena;
	public string modo;
	string veyregresa;
	float minz;
	Vector3 posicioninicial;
	float vel;
	public Transform player_mono;
	public Rigidbody player_mono_rigidbody;
	bool r_oprimido;
	//	public Transform agarrepadre;
	bool othercollider;
	Vector3 objetograndeposicion;

	Vector3 punto_de_ancla;
	bool proceso_Cadena;
	public Transform esferabase;

	bool la_cadena_agarro_algo;
	//public Transform oculusgo_controller;
	// Use this for initialization
	void Start () {
		transform.LookAt(esferabase);
		proceso_Cadena=false;
		movimiento_actual_de_cadena="ve";
		la_cadena_agarro_algo=false;
		if(modo=="pc"){minz=1.77f;
		vel=0.035f;}
		else{minz=0.23f;
		vel=0.12f;}

		posicioninicial=transform.localPosition;
	
	}
	
	// Update is called once per frame
	void UpdateAnterior(){
		/*if(boollist[5]==true||Input.GetKeyDown(KeyCode.W)){if(accion=="atras"){accion="delante";}else{accion="atras";}}

		//si dice atras muevelo pa atras, si dice adelante muevelo pa delante
		if(boollist[4]==true||Input.GetKey(KeyCode.W)){if(accion=="atras"){transform.Translate(0,0,-0.02f);}else{transform.Translate(0,0,0.02f);}}
		
		if(boollist[10]==true||Input.GetKey(KeyCode.R)){
			if(boolregresa==false){
			Nagarra=true;animacion.SetBool("agarra",true);
			}
			}//si mantiene presionado el gatillo
		if(boollist[12]==true||Input.GetKeyUp(KeyCode.R)){
				if(boolregresa==false){
			Nagarra=false;animacion.SetBool("agarra",false);}
			//mueveesamadre=true;
			}//si suelta el gatillo*/
	
	}


	void Update () {
		float B=-1;


		//restart
		if(boollist[34]==true){SceneManager.LoadScene("vr_oculus 2");}

		if(transform.localPosition.z<=minz){}


		//lee comandos de oculus
		oculuslector();

		//si la posicion de la garra en x es menor a 0.4
		//if(transform.localPosition.z<vel-0.1f){}//suelta

		
		//mantiene oprimido GATILLO
		if(boollist[10]==true||Input.GetKey(KeyCode.R)){
			r_oprimido=true;
		
		}

		//suelta el gatillo
		if(boollist[12]==true||Input.GetKeyUp(KeyCode.R)){
			r_oprimido=false;
		}

		if(r_oprimido==true){
			//1.-lanza cadena
			if(la_cadena_agarro_algo==false){//no ha agarrado nada
			transform.Translate(0,0,vel*1f);
			player_mono_rigidbody.useGravity=true;
			//transform.LookAt(esferabase);
			}else{
				transform.LookAt(esferabase);
			//2.-lleva al mono al target
			player_mono_rigidbody.useGravity=false;//quita la gravedad del muñeco para que no se caiga
			if(transform.localPosition.z>minz){
			if(modo!="pc"){
				player_mono.LookAt(transform);
			//center_eye_Ancher.LookAt(transform);
			}
			player_mono.Translate(0,0,vel);//mueve al muñeco
			transform.position=punto_de_ancla;//ancla la garra
			
			}
			
			transform.LookAt(esferabase);
			




			}
		}else{//r_oprimido==false
			transform.localPosition=new Vector3(posicioninicial.x,posicioninicial.y,transform.localPosition.z);
			player_mono_rigidbody.useGravity=true;
			//1.-cadena regresa y suelta lo que sea que tenga
			la_cadena_agarro_algo=false;
			//2.-cadena estatica en posicion inicial
			if(transform.localPosition.z>minz){
				transform.Translate(0,0,vel*-1f);
			}else{
				if(transform.localPosition.z<minz-0.5f){
					transform.localPosition=posicioninicial;
				}

			}
		}
		
		//transform.LookAt(esferabase);
		text.text="r_oprimido"+r_oprimido;
			transform.LookAt(esferabase);
			if(modo=="pc"){
			plataforma.rotation=player_mono.rotation;}
			else{
				plataforma.rotation=ojos.rotation;
			}
			
			if(boollist[4]==true||Input.GetKey(KeyCode.E)){
				plataforma.Translate(0,0,0.2f);
				player_mono.position=plataforma.position;
			}else{
				plataforma.position=player_mono.position;
			}
}//cierra Update


	void metodocadena(){
	
	}


	void ir(){
	
			
			
			
	
	

	}
	void regresar(){
	
	}



	void OnTriggerEnter(Collider other){
			punto_de_ancla=other.transform.position;//ancla la garra
			transform.LookAt(esferabase);
			la_cadena_agarro_algo=true;

	}
	void OnTriggerExit(Collider other){
		
		
	}

	void OnTriggerStay(Collider other){
		punto_de_ancla=transform.position;
		transform.LookAt(esferabase);
	}

	public void oculuslector(){
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
	}
	
}
