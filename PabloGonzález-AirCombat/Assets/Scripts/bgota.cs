using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgota : MonoBehaviour {

	public float rotationSpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		bool isRightPressed = Input.GetKey (KeyCode.RightArrow);

		if(isRightPressed){
			float rotationMagnitude = rotationSpeed * Time.deltaTime;

			Vector3 rotationVector = Vector3.up * rotationMagnitude;

			this.transform.Rotate(rotationVector);
		}



		bool isLeftPressed = Input.GetKey (KeyCode.LeftArrow);

		if(isLeftPressed){
			float rotationMagnitude = rotationSpeed * Time.deltaTime;

			Vector3 rotationVector = Vector3.down * rotationMagnitude;

			this.transform.Rotate(rotationVector);
		}




		bool isForwardPressed = Input.GetKey (KeyCode.UpArrow);


		if(isForwardPressed){
			this.transform.Translate (Vector3.forward);
		
		}



		bool isBackPressed = Input.GetKey (KeyCode.DownArrow);


		if(isBackPressed){

			this.transform.Rotate (60, 0.0f, 0.0f);

		}


	}
	
}
