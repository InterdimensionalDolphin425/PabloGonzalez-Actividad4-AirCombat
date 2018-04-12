using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {

			this.transform.Translate (0.0f, 0.4f, 0.0f);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {

			this.transform.Translate (0.0f, -0.4f, 0.0f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {

			this.transform.Translate (-0.6f, 0.0f, 0.0f);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {

			this.transform.Translate (0.6f, 0.0f, 0.0f);
		}


		if(Input.GetKeyDown(KeyCode.Space)){

			GameObject missile = GameObject.Instantiate (Resources.Load ("Prefabs/Missile") as GameObject);
		

			missile.transform.SetParent (this.gameObject.transform);

			missile.transform.localPosition = new Vector3(0.0f, -2.101f, 0.783f);

			missile.transform.SetParent(null);


		}

		this.transform.Translate (0.0f, 0.0f, 0.2f);
		
	}
}
