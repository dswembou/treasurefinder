using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartMenu()
	{
		SceneManager.LoadScene("StartSpel");
	}

	public void StopSpel()
	{
		Application.Quit();
	}

	public void BeginSpel()
	{
		SceneManager.LoadScene("Start");
	}
}
