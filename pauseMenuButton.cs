using UnityEngine;
using System.Collections;

public class pauseMenuButton : MonoBehaviour {


	void Awake(){
		Time.timeScale = 1;
	}

	public void pauseGame(){
		Time.timeScale = 0;
		GameObject.Find ("Base1").GetComponent<MonsterSpawnerEnemy> ().enabled = false;
	}
}
