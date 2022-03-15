using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour {
	public GameObject characterPrincipal;
	public float velocidad=20f;
	public GameObject bala;
    // Use this for initialization
    void Start() {
    	transform.position = new Vector3 (-3.452276F, 0.1900001F, -3.7048822F);
        
    }

    // Update is called once per frame
    void Update() {
    	//transform.position += Vector3.forward * Time.deltaTime;
    	if(Input.GetKey(KeyCode.UpArrow)){
    		transform.position += transform.forward * Time.deltaTime;

        }
        //Cuando presione la tecla DOWN el carro avanza hacia atrás o en reversa
        if(Input.GetKey(KeyCode.DownArrow)){
    	    transform.position -= transform.forward * Time.deltaTime;

        }
        //Cuando presione la tecla RIGHT
        if(Input.GetKey(KeyCode.RightArrow)){
    	    //transform.eulerAngles += new Vector3.right * Time.deltaTime;
    	    transform.eulerAngles += new Vector3(0,velocidad*Time.deltaTime,0);

        }
        //Cuando presione la tecla LEFT
        if(Input.GetKey(KeyCode.LeftArrow)){
    	    //transform.position -= Vector3.right * Time.deltaTime;
    	    transform.eulerAngles -= new Vector3(0,velocidad*Time.deltaTime,0);
        }
        //Cuando presione la tecla A hago un turbo
        if(Input.GetKeyDown(KeyCode.A)){
        	transform.position += transform.forward *velocidad * Time.deltaTime;

        }
        //Cuando presione la tecla space hago un disparo
        if(Input.GetKey(KeyCode.Space)){
        	Instantiate (bala, transform.position, transform.rotation);

        }
    }
}