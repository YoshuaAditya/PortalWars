using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class buttonInGame : MonoBehaviour {
	
	public Button MainWin, MainLose, Retry, Next;

	void Start(){
	}

	public void gotoMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void retryGame(){		
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

	public void nextGame(){
//		Scenes.Load ("MainMenu", "LevelPanel", "active");
		string levelNow = SceneManager.GetActiveScene().name;
		print (levelNow);
		int level = Convert.ToInt32 (Convert.ToString(levelNow [5]));
		print (level);
		SceneManager.LoadScene ("level" + (level + 1));
	}
}
