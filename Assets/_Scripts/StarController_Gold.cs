using UnityEngine;
using System.Collections;

public class StarController_Gold : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _horizontalSpeed;
	private float _verticalSpeed;

	//PUBLIC INSTANCE VARIABLES
	public float maxHorizontalSpeed = 14f;
	public float minHorizontalSpeed = 8f;
 	public float minVerticalSpeed = -0.5f;
	public float maxVerticalSpeed = 0.5f;
	public float rotateSpeed = 6f;


	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
		this.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2 (this._horizontalSpeed, this._verticalSpeed);
		this._transform.position = this._currentPosition;
		this._transform.Rotate (0,0,rotateSpeed);
		if (this._currentPosition.x <= -2000) {
			this.Reset ();
		}
	}

	void Reset(){
		this._verticalSpeed = Random.Range (this.minVerticalSpeed, this.maxVerticalSpeed);
		this._horizontalSpeed = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		float yPosition = Random.Range (-370,370);
		this._transform.position = new Vector2 (590, yPosition);
	}
}
