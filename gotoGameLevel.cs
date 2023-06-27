using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gotoGameLevel : MonoBehaviour {

	public void gotoLevel(int level)
	{
		SceneManager.LoadScene (level);
	}

}
