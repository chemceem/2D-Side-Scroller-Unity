using UnityEngine;
using System.Collections;

/*
 * @author : Chemcee Cherian
 * Last modified : 05/02/2016 2155hrs
 * */
public class PowerUpController : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _horizontalSpeed;


	//PUBLIC INSTANCE VARIABLES
	public float maxHorizontalSpeed = 14f;
	public float minHorizontalSpeed = 8f;
	public float rotateSpeed = 6f;


	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2 (this._horizontalSpeed, 0);
		this._transform.position = this._currentPosition;
		//this._transform.Rotate (0,0,rotateSpeed);	//disabled rotation for powerup sprite
		if (this._currentPosition.x <= -700) {
			this.Reset ();
		}
	}

	//to reset the position of the object
	void Reset(){		
		this._horizontalSpeed = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		float yPosition = Random.Range (-370,370);
		this._transform.position = new Vector2 (2400, yPosition);
	}
}
