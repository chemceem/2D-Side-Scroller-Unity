using UnityEngine;
using System.Collections;

/*
 * @author : Chemcee Cherian
 * Last modified : 05/02/2016 2155hrs
 * */
public class SpaceshipCollider : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private AudioSource[] _audioSources;
	private AudioSource _starSound;
	private AudioSource _asteroidSound;
	private AudioSource _powerUpSound;

	//PUBLIC INSTANCE VARIABLES
	public GameController gameController;
	public StarController_Gold goldStar;
	public StarController_Silver silverStar;
	public PowerUpController powerUp;

	// Use this for initialization
	void Start () {
		//initialize the audio array
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._asteroidSound = _audioSources [1];
		this._starSound = _audioSources [2];
		this._powerUpSound = _audioSources [3];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("GoldStar")) {
			this._starSound.Play ();
			this.gameController.ScoreValue += 100;
			goldStar.transform.position = new Vector2 (1600, Random.Range(-370,370));
		}

		if (other.gameObject.CompareTag ("SilverStar")) {
			this._starSound.Play ();
			this.gameController.ScoreValue += 50;
			silverStar.transform.position = new Vector2 (620, Random.Range(-370,370));
		}

		if (other.gameObject.CompareTag ("Asteroid")) {
			this._asteroidSound.Play ();
			this.gameController.LivesValue--;
		}

		if(other.gameObject.CompareTag("Powerup")){
			this._powerUpSound.Play ();
			this.gameController.LivesValue += 1;
			powerUp.transform.position = new Vector2 (2500, Random.Range(-370,370));
		}
	}
}
