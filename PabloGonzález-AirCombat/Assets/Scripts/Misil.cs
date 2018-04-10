using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (0.0f, 0.0f, 1);
		
	}

	void OnCollisionEnter(Collision collision) {


		Debug.Log ("lmao");
		Destroy (collision.collider.gameObject);
		Destroy(gameObject);



	}
}
