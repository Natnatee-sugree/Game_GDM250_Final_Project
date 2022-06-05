using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Text ScoreText;
	public int score;
	public static int currentscore;
	public Text highscore;
	void Start()
	{
		score = 0;
		currentscore = 0;
		ScoreText.text = " " + score.ToString();
		Enemy.ScoreListener(Onscroeevent);
		highscore.text = PlayerPrefs.GetInt("HighScore : ", 0).ToString();
	}
	public void Onscroeevent(int enemyscore)
    {
		score += enemyscore;
		ScoreText.text = " " + score.ToString();
	}

	void Update()
	{
		PlayerPrefs.SetInt("HighScore : ", score);
	}
	public void Reset()
	{
		PlayerPrefs.DeleteAll();
		highscore.text = "0";
	}
}
