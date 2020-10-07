using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
	private float _tijd;
	
	Text TijdTxt;
	Text ScoreTxt;

	private bool _gameOver = false;

	public int Score { get; set; }
	// Use this for initialization
	void Start ()
	{
		_tijd = 30f;
		DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update ()
	{

		ScoreTxt = GameObject.Find("Score").GetComponent<Text>();
		TijdTxt = GameObject.Find("Tijd").GetComponent<Text>();

		if (_tijd > 0f)
		{
			_tijd -= Time.deltaTime;
		}
		else
		{
			_tijd = 0f;
			if (_gameOver == false)
			{
				Einde();
			}
			
		}

		TijdTxt.text = _tijd.ToString("F0");
		ScoreTxt.text = Score.ToString();
	}

	void Einde()
	{
		_gameOver = true;
		SceneManager.LoadScene("EindeSpel");
	}
}
