using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * @author : Chemcee Cherian
 * Last modified : 05/02/2016 2155hrs
 * */
public class StartMenuController : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLES
	public Button startGameButton;
	public Button instructionButton;
	public Button creditButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//start the game, load the main game
	public void StartGame()	{
		SceneManager.LoadScene("main");
	}

	//shows the instruction scene
	public void showInstructions(){
		SceneManager.LoadScene ("instructions");
	}
}
