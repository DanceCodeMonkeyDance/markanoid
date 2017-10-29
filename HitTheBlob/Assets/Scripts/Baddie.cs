using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Baddie : MonoBehaviour {

	public int Life;

	// Use this for initialization
	void Start () {
		if (Life == 0) {
			Life = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log("Context With Baddy");
		if (coll.gameObject.tag == "Player") {
			
			if (Life > 0) {
				Life--;

			} else {
				Destroy (gameObject);
			}
		}

	}

	void OnCollisionExit2D(Collision2D coll) {

	} 
}
