using UnityEngine;
using System.Collections;

public class SpaceController : MonoBehaviour {

	//PRIVATE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;

	//PUBLIC VARIABLES
	float speed = 5f;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
		this.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2 (speed, 0);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x <= -456) {
			Reset ();
		}		
	}

	void Reset(){
		this._transform.position = new Vector2 (456f, 0);
	}
}
