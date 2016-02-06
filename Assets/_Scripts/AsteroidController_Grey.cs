using UnityEngine;
using System.Collections;

/*
 * @author : Chemcee Cherian
 * Last modified : 05/02/2016 2155hrs
 * */
public class AsteroidController_Grey : MonoBehaviour {

	//public instance variables
	public float rotationSpeed = -2f;
	public float maxVerticalSpeed = 3f;
	public float minVerticalSpeed = -3f;
	public float maxHorizontalSpeed = 16f;
	public float minHorizontalSpeed = 7f;

	//private instance variables
	Transform _transform;
	Vector2 _currentPosition;
	private float _verticalSpeed;
	private float _horizontalSpeed;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();

		//to reset the asteroid to the top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2 (this._horizontalSpeed, this._verticalSpeed);
		this._transform.position = this._currentPosition;
		this._transform.Rotate (0,0,rotationSpeed);
		if (_transform.position.x <= -700) {
			this.Reset ();
		}
	}

	void Reset(){
		this._verticalSpeed = Random.Range (this.minVerticalSpeed, this.maxVerticalSpeed);
		this._horizontalSpeed = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		float yPosition = Random.Range (-315,315);
		this._transform.position = new Vector2 (750, yPosition);
	}
}
