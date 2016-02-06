using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * @author : Chemcee Cherian
 * Last modified : 05/02/2016 2155hrs
 * */
public class InstructionSceneController : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLES
	public Button menuButton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ShowMenu(){
		SceneManager.LoadScene ("start");
	}
}
