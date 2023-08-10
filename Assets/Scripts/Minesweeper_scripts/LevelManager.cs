using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public void StarGame()
	{
		SceneManager.LoadScene("Minesweeper");
	}
	
	public void GotoMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
	
	public void QuitGame()
	{
		Application.Quit();
		Debug.Log("Quit!");
	}
	
}
