using UnityEngine;
using System.Collections;

/*
 * @author : Chemcee Cherian
 * last modified : 05/02/2016 , 1030hrs
 * */
public class SpaceshipCollider : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private AudioSource[] _audioSources;
	private AudioSource _starSound;
	private AudioSource _asteroidSound;

	//PUBLIC INSTANCE VARIABLES
	public GameController gameController;
	public StarController_Gold goldStar;
	public StarController_Silver silverStar;

	// Use this for initialization
	void Start () {
		//initialize the audio array
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._asteroidSound = _audioSources [1];
		this._starSound = _audioSources [2];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("GoldStar")) {
			this._starSound.Play ();
			this.gameController.ScoreValue += 100;
			goldStar.transform.position = new Vector2 (1900, Random.Range(-370,370));
		}

		if (other.gameObject.CompareTag ("SilverStar")) {
			this._starSound.Play ();
			this.gameController.ScoreValue += 100;
			silverStar.transform.position = new Vector2 (620, Random.Range(-370,370));
		}

		if (other.gameObject.CompareTag ("Asteroid")) {
			this._asteroidSound.Play ();
			this.gameController.LivesValue--;
		}
	}
}
