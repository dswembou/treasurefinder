using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	private ScoreKeeper _scoreKeeper;
	// Use this for initialization
	void Start ()
	{
		_scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
