using UnityEngine;
using System.Collections;

/*
 * @author : Chemcee Cherian
 * Last modified : 05/02/2016 2155hrs
 * */
public class SpaceController : MonoBehaviour {

	//PRIVATE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;

	//PUBLIC VARIABLES
	public  float speed = 5f;

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

		if (this._currentPosition.x <= -300) {
			Reset ();
		}		
	}

	public void Reset(){
		this._transform.position = new Vector2(300f, 0);
	}
}	