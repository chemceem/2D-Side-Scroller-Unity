using UnityEngine;
using System.Collections;

public class Brown_AsteroidController : MonoBehaviour {

	//public instance variables
	public float rotationSpeed = 2f;
	public float maxVerticalSpeed = 2f;
	public float minVerticalSpeed = -2f;
	public float maxHorizontalSpeed = 17f;
	public float minHorizontalSpeed = 8f;

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

		if (_transform.position.x <= -630) {
			this.Reset ();
		}
	}

	void Reset(){
		this._verticalSpeed = Random.Range (this.minVerticalSpeed, this.maxVerticalSpeed);
		this._horizontalSpeed = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		float yPosition = Random.Range (-355,355);
		this._transform.position = new Vector2 (690, yPosition);
	}
}
