using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//public instance variables
	public int greyAsteroidNumber = 3;
	public int brownAsteroidNumber = 4;
	public Grey_AsteroidController grey_asteroid;
	public Brown_AsteroidController brown_asteroid;

	//private instance variables


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
		for (int greyCount = 0; greyCount < greyAsteroidNumber; greyCount++) {   
			//Vector3 scale = new Vector3((transform.localScale.x+greyCount),(transform.localScale.y+greyCount),(transform.localScale.z+greyCount));
			//Instantiate (grey_asteroid.gameObject,scale,transform.rotation);
			GameObject greygame = Instantiate (grey_asteroid.gameObject);
			if (greyCount < 2) {
				greygame.transform.localScale = new Vector3 (1,1,1);
			}
		}

		for (int brownCount = 0; brownCount < brownAsteroidNumber; brownCount++) {
			GameObject browngame = Instantiate (brown_asteroid.gameObject);
			if (brownCount < 3) {
				browngame.transform.localScale = new Vector3 (1,1,1);
			}
		}
	}
}
