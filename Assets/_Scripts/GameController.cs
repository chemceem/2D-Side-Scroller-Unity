﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
 * @author : Chemcee Cherian
 * Last Modified : 05/02/2016
 * */
public class GameController : MonoBehaviour {

	//private instance variables
	private int _scoreValue;
	private int _lifeValues;

	//public instance variables
	public int noOfGreyAsteroids = 3;	//three grey asteroids
	public int noOfBrownAsteroids = 4; //four brown asteroids
	public AsteroidController_Grey grey_asteroid;
	public AsteroidController_Brown brown_asteroid;
	public Text LivesText;
	public Text ScoreText;
	public Text GameoverText;
	public ShipController spaceShip;
	public StarController_Gold goldStar;
	public StarController_Silver silverStar;

	//PUBLIC ACCESS METHODS
	public int ScoreValue{
		get { 
			return _scoreValue;
		}
		set { 
			this._scoreValue = value;
			this.ScoreText.text = "Score : " + this._scoreValue;
		}
	}

	public int LivesValue {
		get { 
			return _lifeValues;
		}
		set{ 
			this._lifeValues = value;
			if (this._lifeValues <= 0) {
				this._endGame ();
			} else {
				this.LivesText.text = "Lives : " + this._lifeValues;
			}
		}
	}

	// Use this for initialization
	void Start () {
		this._initialize ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//PRIVATE METHODS

	//inital method
	private void _initialize(){
		this.ScoreValue = 0;
		this.LivesValue = 5;
		this.GameoverText.enabled = false;

		for (int greyCount = 0; greyCount < noOfGreyAsteroids; greyCount++) {   
			//Vector3 scale = new Vector3((transform.localScale.x+greyCount),(transform.localScale.y+greyCount),(transform.localScale.z+greyCount));
			//Instantiate (grey_asteroid.gameObject,scale,transform.rotation);
			GameObject greygame = Instantiate (grey_asteroid.gameObject);
			//one asteroid will be scaled to twice the size
			if (greyCount < 2) {
				greygame.transform.localScale = new Vector3 (1,1,1);
			}
		}

		for (int brownCount = 0; brownCount < noOfBrownAsteroids; brownCount++) {
			GameObject browngame = Instantiate (brown_asteroid.gameObject);
				//one asteroid will be scaled to twice the size
			if (brownCount < 3) {
				browngame.transform.localScale = new Vector3 (1,1,1);
			}
		}
	}

	private void _endGame(){
		this.GameoverText.enabled = true;
		this.LivesText.text = "Lives : 0";
		this.spaceShip.gameObject.SetActive(false);
		this.silverStar.gameObject.SetActive(false);
		this.goldStar.gameObject.SetActive(false);
	}
}
