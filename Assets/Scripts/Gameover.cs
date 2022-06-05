using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Gameover : MonoBehaviour
{
	public GameObject GOpanal;
	void Start()
	{
		GOpanal.SetActive(false);
	}

	public void Game_over()
	{
		GOpanal.SetActive(true);
	}
	public void Restart()
	{
		SceneManager.LoadScene(0);
	}
}
