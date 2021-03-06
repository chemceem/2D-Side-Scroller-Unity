﻿using UnityEngine;
using System.Collections;

/*
 * @author : Chemcee Cherian
 * Last modified : 05/02/2016 2155hrs
 * */
public class ShipController : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _playerInput;

	//PUBLIC INSTANCE VARIABLES
	public float speed = 12f;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
		this._transform.position = new Vector2 (-520f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._playerInput = Input.GetAxis ("Vertical");

		if (this._playerInput > 0) {
			this._currentPosition += new Vector2(0, this.speed);
		}

		if (this._playerInput < 0) {
			this._currentPosition -= new Vector2 (0, this.speed);
		}
		this.Checkbound ();
		this._transform.position = this._currentPosition;
	}

	//check if the ship has gone beyond the border of the game
	private void Checkbound() {
		if (this._currentPosition.y < -348) {
			this._currentPosition.y = -348;
		}

		if(this._currentPosition.y > 348) {
			this._currentPosition.y = 348;
		}
	}
}