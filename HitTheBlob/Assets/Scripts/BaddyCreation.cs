using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaddyCreation : MonoBehaviour {

	public int NumberOfBaddies;
	public GameObject BaddyObject;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < NumberOfBaddies; i++) {

			Instantiate (BaddyObject , new Vector3((i * 1) - 9,4) , Quaternion.identity);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
