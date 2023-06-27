using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonEvent : MonoBehaviour {

	// Use this for initialization
	public Canvas mainmenu;
	public Button start, option, credit, exit;

	public void toGameLevel()
	{
		SceneManager.LoadScene("Overview");
	}

	public void toExit()
	{
		Application.Quit ();
	}
		
}
