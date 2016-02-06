using UnityEngine;
using System.Collections;

/*
 * @author : Chemcee Cherian
 * Last modified : 05/02/2016 2155hrs
 * */
public class StarController_Silver : MonoBehaviour {

	//public instance variables
	public float speed = 7f;
	public float rotationSpeed = -4f;

	//private instance variables
	Transform _transform;
	Vector2 _currentPosition;

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
		this._transform.Rotate (0,0,rotationSpeed);

		if (_transform.position.x <= -580) {
			this.Reset ();
		}
	}

	void Reset(){
		float yPosition = Random.Range (-370,370);
		this._transform.position = new Vector2 (590, yPosition);
	}
}
