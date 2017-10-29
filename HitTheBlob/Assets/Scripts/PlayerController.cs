using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	Rigidbody2D _playerRigidBody;
	bool contactMade;
	int score;

	public int travelSpeed;
	public Text ScoreText;

	// Use this for initialization
	void Start () {
		_playerRigidBody = GetComponent<Rigidbody2D> ();
		ScoreText.text = "Score: " + score.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {

		//Debug.Log (contactMade);

		var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		var mouseDir = mousePos - gameObject.transform.position;
		mousePos.z = 0.0f;
		mouseDir = mouseDir.normalized;

		if (Input.GetMouseButtonDown(0) && contactMade) {
			//contactMade = false;
			_playerRigidBody.AddForce(mouseDir * 1500);
		}

	}

	void OnCollisionEnter2D(Collision2D coll) {
		//Debug.Log (coll.gameObject.tag);

		if (coll.gameObject.CompareTag( "background")) {
			contactMade = true;
		}

		if (coll.gameObject.CompareTag("baddy")) {
			score++;
			ScoreText.text = "Score: " + score.ToString ();
		}

	}

	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.CompareTag("background")) {
			contactMade = false;
		}
			
	}

}
