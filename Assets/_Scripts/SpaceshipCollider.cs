using UnityEngine;
using System.Collections;

public class SpaceshipCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Star")) {
			Debug.Log ("collided with star");
		}

		if (other.gameObject.CompareTag ("Asteroid")) {
			Debug.Log ("collided with asteroid");
		}
	}
}
